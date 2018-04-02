using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MigrationData.DAL;

namespace JYM.AutoSystem
{
    public partial class BatchDebtForm : Form
    {
        public BatchDebtForm()
        {
            this.InitializeComponent();
            this.LoadData = new LoadPageData(this.btn_FirstPage, this.btn_left, this.btn_right, this.btn_LastPage, this.btn_Go, this.lbl_pageinfo1
                , this.lbl_pageinfo2, this.txt_pageIndex, 30, this.dgv_Data, new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            CheckForIllegalCrossThreadCalls = false;
        }

        public LoadPageData LoadData { get; }
        public string WhereExpression { get; set; } = string.Empty;

        private void BatchDebtForm_Load(object sender, EventArgs e)
        {
            this.LoadData.PicShow = this.picShow;
            this.cbx_pageSize.SelectedIndex = 0;
            this.LoadPageData(null, " order by Id desc");
            this.LoadData.Lbl_infos1.Text = "每页";
            //为页面容量设置改变事件
            this.cbx_pageSize.SelectedValueChanged += (objP, exP) =>
            {
                //获取此时的页码
                int pageSize = Convert.ToInt32(this.cbx_pageSize.Text);
                this.LoadData.PageSize = pageSize;
                this.LoadData.PageIndex = 1;
                this.LoadPageData(this.WhereExpression, " order by Id asc");
                this.LoadData.Lbl_infos1.Text = "每页";
            };
        }

        private void dgv_Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        /// <summary>
        ///     加载数据
        /// </summary>
        /// <param name="where"></param>
        /// <param name="order"></param>
        private void LoadPageData(string where = null, string order = null)
        {
            //select * from ( select *,ROW_NUMBER() OVER(Order by Id) as rownum from Account) as twhere t.rownum between (@pageIndex - 1) * pageSize + 1 and @pageSize * pageIndex order by t.Id asc
            this.LoadData.Func = () => SqlHelperByYem.Query($"select * from(select *,ROW_NUMBER() OVER({order}) as rownum from core.UserAssetRatios where  IsDelete=0 and Status in(10,20,40) and DeptRedeemStatus=10 {where})as t where t.rownum between {(this.LoadData.PageIndex - 1) * this.LoadData.PageSize + 1} and {this.LoadData.PageSize * this.LoadData.PageIndex}", null, false);

            this.LoadData.FuncNums = () => Convert.ToInt16(SqlHelperByYem.ExecuteScalar($"select count(*) from core.UserAssetRatios where  IsDelete=0 and Status in(10,20,40) and DeptRedeemStatus=10  {where}"));

            this.LoadData.LoadOneTablePageData();
            this.LoadData.Action = () => this.LoadData.Lbl_infos1.Text = "每页";
            this.LoadData.Atcion1 = () => { };
        }
    }
}