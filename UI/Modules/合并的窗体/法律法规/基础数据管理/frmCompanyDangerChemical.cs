﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EnforceUI;
using SOA;
using SOA.ORM;
using Common;

namespace EnforceForm
{
    public partial class frmCompanyDangerChemical : BaseTableForm
    {
        public CompanyDangerChemicals CompanyDangerChemicals;
        public frmCompanyDangerChemical()
        {
            InitializeComponent();
        }
        public frmCompanyDangerChemical(CompanyDangerChemicals CompanyDangerChemicals)
            : this()
        {
            this.CompanyDangerChemicals = CompanyDangerChemicals;
        }
        private void frmCompanyDangerChemical_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (CompanyDangerChemicals != null)
                {

                    this.BusinessMode.Text = CompanyDangerChemicals.BusinessMode;
                    BusinessScope.Text = CompanyDangerChemicals.BusinessScope;
                    Certificate.Text = CompanyDangerChemicals.Certificate;
                    EconomicTypes.Text = CompanyDangerChemicals.EconomicTypes;
                    WarehousAddress.Text = CompanyDangerChemicals.WarehousAddress;
                    ValidStartDate.Text = CompanyDangerChemicals.ValidStartDate.ToString();
                    ValidEndDate.Text = CompanyDangerChemicals.ValidEndDate.ToString();

                    CompanyAddress.Text = CompanyDangerChemicals.Company.CompanyAddress;
                    CompanyName.Text = CompanyDangerChemicals.Company.CompanyName;
                    CompanyPost.Text = CompanyDangerChemicals.Company.CompanyPost;
                    JuridicalPerson.Text = CompanyDangerChemicals.Company.JuridicalPerson;
                    JuridicalPersonAge.Text = CompanyDangerChemicals.Company.JuridicalPersonAge;
                    JuridicalPersonJob.Text = CompanyDangerChemicals.Company.JuridicalPersonJob;
                    JuridicalPersonSex.Text = CompanyDangerChemicals.Company.JuridicalPersonSex;
                    Mobile.Text = CompanyDangerChemicals.Company.Mobile;
                    Tel.Text = CompanyDangerChemicals.Company.Tel;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Application.DoEvents();

            try
            {
                if (CompanyDangerChemicals == null)
                    CompanyDangerChemicals = new CompanyDangerChemicals();

                //GetEntity(CompanyDangerChemicals);

                CompanyDangerChemicals.BusinessMode = this.BusinessMode.Text.Trim();
                CompanyDangerChemicals.BusinessScope = BusinessScope.Text.Trim();
                CompanyDangerChemicals.Certificate = Certificate.Text.Trim();
                CompanyDangerChemicals.EconomicTypes = EconomicTypes.Text.Trim();
                CompanyDangerChemicals.WarehousAddress = WarehousAddress.Text;
                CompanyDangerChemicals.ValidStartDate = DateTime.Parse(ValidStartDate.Text);
                CompanyDangerChemicals.ValidEndDate = DateTime.Parse(ValidEndDate.Text);

                CompanyDangerChemicals.Company.CompanyAddress = CompanyAddress.Text.Trim();
                CompanyDangerChemicals.Company.CompanyName = CompanyName.Text.Trim();
                CompanyDangerChemicals.Company.CompanyPost = CompanyPost.Text.Trim();
                CompanyDangerChemicals.Company.JuridicalPerson = JuridicalPerson.Text.Trim();
                CompanyDangerChemicals.Company.JuridicalPersonAge = JuridicalPersonAge.Text.Trim();
                CompanyDangerChemicals.Company.JuridicalPersonJob = JuridicalPersonJob.Text.Trim();
                CompanyDangerChemicals.Company.JuridicalPersonSex = JuridicalPersonSex.Text.Trim();
                CompanyDangerChemicals.Company.Mobile = Mobile.Text.Trim();
                CompanyDangerChemicals.Company.Tel = Tel.Text.Trim();
                
                InvokeUtil.SystemService.EntityUpdate(CompanyDangerChemicals);
                CommonInvoke.MessageBox("操作成功！");
                CloseWindow();
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }

            UseWaitCursor = false;
        }
    }
}
