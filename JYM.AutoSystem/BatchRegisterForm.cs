using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using JYM.Lib;
using JYM.Model;
using JYM.Service;
using MigrationData.DAL;

namespace JYM.AutoSystem
{
    public partial class BatchRegisterForm : Form
    {
        private readonly JymService jymService = new JymService();
        private readonly object objLock = new object();

        /// <summary>
        /// </summary>
        public BatchRegisterForm()
        {
            CheckForIllegalCrossThreadCalls = false;
            this.InitializeComponent();
        }

        /// <summary>
        ///     注册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BatchRegisterForm_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        ///     点击开始注册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                this.lbl_msg.Text = string.Empty;
                this.txb_SuccessNums.Text = "0";
                long totalNums = Convert.ToInt64(this.txb_Nums.Text.Trim());
                if (totalNums == 0)
                {
                    MessageBox.Show("请输入注册数量");
                    return;
                }
                this.btn_Submit.Enabled = false;
                this.lbl_msg.Text = "正在开始注册.....";
                List<Task> listTasks = new List<Task>();
                List<long> listDatas = new List<long>();
                for (int i = 1; i <= totalNums; i++)
                {
                    listDatas.Add(i);
                }
                for (int i = 0; i < 3; i++)
                {
                    Task task = Task.Run(async () =>
                    {
                        //执行
                        while (listDatas.Count > 0)
                        {
                            long data = 0;
                            lock (this.objLock)
                            {
                                if (listDatas.Count > 0)
                                {
                                    data = listDatas[0];
                                    listDatas.Remove(data);
                                }
                            }
                            if (data == 0) continue;
                            Tuple<string, string> infos = AutoCreateAnyCode.GetUserName1();
                            AccountUsers user = new AccountUsers
                            {
                                CellPhone = infos.Item2,
                                Pwd = "111111",
                                RealName = infos.Item1,
                                BankCardNo = AutoCreateAnyCode.GetBankCardNo(),
                                CredentialNo = AutoCreateAnyCode.GetCredentialNo(),
                                UserMac = AutoCreateAnyCode.GetMacAddressByNetworkInformation(),
                                CgCellPhone = AutoCreateAnyCode.GetCellPhone(),
                                RigisterTime = DateTime.Now.ToString("yyyyMMdd HH:mm:ss")
                            };
                            if (!this.jymService.CheckCellPhone(user.CellPhone).Result)
                            {
                                continue;
                            }
                            user.RealName = user.RealName == "" ? AutoCreateAnyCode.GetUserName() : user.RealName;
                            user.InviteBy = user.InviteBy == "" ? "22222" : user.InviteBy;
                            user.CgCellPhone = user.CgCellPhone == "" ? AutoCreateAnyCode.GetCellPhone() : user.CgCellPhone;
                            //注册认证
                            AccountUsers successAccountUsers = await this.Register(user);
                            if (successAccountUsers != null)
                            {
                                //成功
                                lock (this.objLock)
                                {
                                    this.txb_SuccessNums.Text = (Convert.ToInt64(this.txb_SuccessNums.Text) + 1).ToString();
                                }
                            }
                        }
                    });
                    listTasks.Add(task);
                }
                Task.WhenAll(listTasks);
                this.btn_Submit.Enabled = true;
            }
            catch (Exception exception)
            {
                this.btn_Submit.Enabled = true;
                this.lbl_msg.Text = exception.Message;
            }
        }

        /// <summary>
        ///     注册
        /// </summary>
        /// <returns></returns>
        private async Task<AccountUsers> Register(AccountUsers user)
        {
            //注册一个用户
            string cellphone = user.CellPhone;
            //RegisterSuccessInfo responseRegisterSuccessInfo = new RegisterSuccessInfo { IsSuccess = false };
            //发送验证码 并且验证该手机号是否存在
            //发送验证码
            SmsCodeInfo smsCodeInfo = await this.jymService.GetSmsCodeInfo(new SendVeriCodeRequest { Cellphone = cellphone });
            //验证
            if (await this.jymService.VerifyCellPhone(new VerifyRequest { Cellphone = cellphone, Code = smsCodeInfo.Code.Split('|')[0], Type = 10 }))
            {
                //成功后注册
                RegisterInfo info = new RegisterInfo { Token = smsCodeInfo.Token, InviteBy = user.InviteBy, ContractId = "300020150820103000", Password = user.Pwd };
                if (await this.jymService.Register(info))
                {
                    //认证
                    string realName = user.RealName;
                    string credentialNo = user.CredentialNo;
                    IdentityAuthenticationResponse registerSuccess = await this.jymService.IdentityAuthentication(new IdentityAuthenticationRequest { Credential = "10", CredentialNo = credentialNo, RealName = realName }, cellphone, user.Pwd);
                    if (registerSuccess.IsSuccess)
                    {
                        user.UserIdentifier = registerSuccess.UserIdentifier;
                        user.IsVerifed = 1;
                        //将数据存入数据库中
                        bool addSuccess = SqlHelper.ExecuteNoneQuery($"insert into AccountUsers(BankCardNo,CellPhone,CgCellPhone,CredentialNo,InviteBy,InviteFor,IsActivity,IsAuthInvest,IsAuthWithdraw,IsVerifed,Pwd,RealName,RechargeAmount,RechargeNums,RigisterTime,UserIdentifier,UserMac,IsBankAuth)values('{user.BankCardNo}','{user.CellPhone}','{user.CgCellPhone}','{user.CredentialNo}','{user.InviteBy}','{user.InviteFor}',{user.IsActivity},{user.IsAuthInvest},{user.IsAuthWithdraw},{user.IsVerifed},'{user.Pwd}','{user.RealName}',{user.RechargeAmount},{user.RechargeNums},'{user.RigisterTime}','{user.UserIdentifier}','{user.UserMac}',0)") > 0;
                        if (addSuccess)
                        {
                            return user;
                        }
                    }
                    return null;
                }
            }
            return null;
        }
    }
}