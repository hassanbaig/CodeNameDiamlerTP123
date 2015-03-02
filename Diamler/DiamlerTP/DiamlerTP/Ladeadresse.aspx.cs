using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DiamlerTP.DAL;

namespace DiamlerTP
{
    public partial class Ladeadresse : System.Web.UI.Page
    {
        private LoadAdressDataProvider _LoadAdressDataProvider;
        private LoadAdress _loadAdress;
        private List<LoadAdress> _LAdress;
        private string[] arrColumn;
        private string[] arrValue;
        private DataProvider _dataProvider;
        protected void Page_Load(object sender, EventArgs e)
        {
            _LoadAdressDataProvider = new LoadAdressDataProvider();
            _dataProvider = new DataProvider();
            _loadAdress = new LoadAdress();
            _LAdress = _LoadAdressDataProvider.GetLAdress();
            DDLLand.DataSource = _LAdress;
            DDLLand.DataBind();
            DDLSuchname.DataSource = _LAdress;
            DDLSuchname.DataBind();
        }


        protected void btn_Click(object sender, EventArgs e)
        {
            arrColumn = new string[9];
            arrValue = new string[9];
            arrColumn[0] = "SearchName";
            arrColumn[1] = "Name1";
            arrColumn[2] = "Name2";
            arrColumn[3] = "Street1";
            arrColumn[4] = "Street2";
            arrColumn[5] = "PostCode";
            arrColumn[6] = "City";
            arrColumn[7] = "Region";
            arrColumn[8] = "Country";

            arrValue[0] = "'" + txtSuchname.Text + "'";
            arrValue[1] = "'" + txtName1.Text + "'";
            arrValue[2] = "'" + txtName2.Text + "'";
            arrValue[3] = "'" + txtStrasse1.Text + "'";
            arrValue[4] = "'" + txtStrasse2.Text + "'";
            arrValue[5] = "'" + txtPlz.Text + "'";
            arrValue[6] = "'" + txtStadt.Text + "'";
            arrValue[7] = "'" + txtRegion.Text + "'";
            arrValue[8] = "'" + DDLLand.SelectedValue + "'";


            object result = _dataProvider.ManipulateData(QueryCreater.InsertQuery("T_LoadAdress", arrColumn, arrValue));

            if (result != null)
            {
                lblsuccess.Visible = true;
            }

        }

    }
}

