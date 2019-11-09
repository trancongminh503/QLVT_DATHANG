﻿using System;
using System.Data;

namespace QLVT_DATHANG.Forms
{
   using DevExpress.XtraBars;
   using DevExpress.XtraEditors;
   using Utility;

   public partial class frmGoodsReceivedNote : XtraForm
   {
      private string _currentDeploymentId;
      //private int _currentPosition;
      private ButtonActionType _buttonAction;
      private MyStack _userDo;

      public frmGoodsReceivedNote()
      {
         InitializeComponent();
         SetupControls();
      }

      private void GoodsReceivedNote_Load(object sender, EventArgs e)
      {
         _buttonAction = ButtonActionType.None;
         _userDo = new MyStack();
         _userDo.StackPushed += userDo_StackPushed;
         _userDo.StackPopped += userDo_StackPopped;

         LoadTable();
         DisableEditMode();

         _currentDeploymentId = ((DataRowView)bdsPN[0])["MAPN"].ToString().Trim();

         // Quyền công ty => enable combobox chi nhánh
         ShowControlsByGroup(UtilDB.CurrentGroup);
      }

      #region METHOD

      private void ShowControlsByGroup(string grName)
      {
         if (grName.Equals("congty"))
         {
            UtilCommon.SetupDSCN(cboDeployment);
            cboDeployment.Visible = true;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
         }
      }

      private void SetupControls()
      {
         //string nameRegex = "[\u0000-\u001F\007F-\u009F]+(\\s{1}[\u0000-\u001F\007F-\u009F]+)*"; // regex with one space between 2 character

         //txtEmpId.Properties.Mask.MaskType = MaskType.RegEx;
         //txtEmpId.Properties.Mask.EditMask = "\\d+";
         //txtEmpId.Properties.Mask.BeepOnError = true;
         //txtEmpId.Properties.AllowNullInput = DefaultBoolean.True;
         //////txtEmpId.Properties.NullValuePrompt = "Id here";

         //txtEmpFirstName.Properties.Mask.MaskType = MaskType.None;
         //txtEmpFirstName.Properties.Mask.EditMask = nameRegex;
         //txtEmpFirstName.Properties.Mask.BeepOnError = true;
         //txtEmpFirstName.Properties.AllowNullInput = DefaultBoolean.True;
         //////txtEmpFirstName.Properties.NullValuePrompt = "First name here";

         //txtEmpLastName.Properties.Mask.MaskType = MaskType.None;
         //txtEmpLastName.Properties.Mask.EditMask = nameRegex;
         //txtEmpLastName.Properties.Mask.BeepOnError = true;
         //txtEmpLastName.Properties.AllowNullInput = DefaultBoolean.True;
         //////txtEmpLastName.Properties.NullValuePrompt = "Last name here";

         //txtEmpAddr.Properties.Mask.BeepOnError = true;
         //txtEmpAddr.Properties.AllowNullInput = DefaultBoolean.True;
         //////txtEmpAddr.Properties.NullValuePrompt = "Address here";

         //spiEmpSalary.Properties.Mask.MaskType = MaskType.Numeric;
         ////spiEmpSalary.Properties.MinValue = CommonCons.MinSalary;
         //spiEmpSalary.Properties.Increment = 100000;
         //spiEmpSalary.Properties.Mask.BeepOnError = true;
         //spiEmpSalary.Properties.AllowNullInput = DefaultBoolean.True;
         ////spiEmpSalary.Properties.NullValuePrompt = $"Min {CommonCons.MinSalary}";

         //dtpEmpBirth.Properties.Mask.MaskType = MaskType.DateTime;
         //dtpEmpBirth.Properties.Mask.EditMask = "dd//MM//yyyy";
         //dtpEmpBirth.Properties.MaxValue = DateTime.Today.AddDays(-1);
         //dtpEmpBirth.Properties.Mask.BeepOnError = true;
         //dtpEmpBirth.Properties.AllowNullInput = DefaultBoolean.True;
         ////dtpEmpBirth.Properties.NullValuePrompt = "Pick a day";
      }

      private void userDo_StackPopped(object sender, StackEventAgrs e)
      {
         if (_userDo.Count == 0)
         {
            btnUndo.Enabled = false;
         }
      }

      private void userDo_StackPushed(object sender, StackEventAgrs e)
      {
         if (_userDo.Count == 1)
         {
            btnUndo.Enabled = true;
         }
      }

      private void LoadTable()
      {
         // Đoạn này quan trọng. Đăng nhập bằng user nào => connectionString tương ứng
         this.taPN.Connection.ConnectionString =
            UtilDB.ConnectionString;
         try
         {
            this.dataSet.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'dataSet.PhieuNhap' table. You can move, or remove it, as needed.
            this.taPN.Fill(this.dataSet.PhieuNhap);

            //this.dataSet.EnforceConstraints = true;
         }
         catch (Exception ex)
         {
            UtilCommon.ShowError(ex);
         }
      }

      private void DisableEditMode()
      {
         btnDel.Enabled = (bdsPN.Count == 0) ? false : true;

         gcReceivedNote.Enabled = true;
         gbReceivedNote.Enabled = false;

         btnAdd.Enabled = true;
         btnDel.Enabled = true;
         btnEdit.Enabled = true;
         btnExit.Enabled = true;
         btnRefresh.Enabled = true;
         btnUndo.Enabled = (_userDo.Count == 0) ? false : true;

         btnCancelEdit.Enabled = false;
         btnCancelEdit.Visibility = BarItemVisibility.Never;

         btnSave.Enabled = false;
         btnSave.Visibility = BarItemVisibility.Never;
      }

      #endregion
   }
}