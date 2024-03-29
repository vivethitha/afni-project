﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace SubmissionCase_E2E
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Edit_Adverse_Vechicle_Infromation recording.
    /// </summary>
    [TestModule("e9cfa9fa-52da-49fa-a342-1bb9657f1ac6", ModuleType.Recording, 1)]
    public partial class Edit_Adverse_Vechicle_Infromation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SubmissionCase_E2ERepository repository.
        /// </summary>
        public static SubmissionCase_E2ERepository repo = SubmissionCase_E2ERepository.Instance;

        static Edit_Adverse_Vechicle_Infromation instance = new Edit_Adverse_Vechicle_Infromation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Edit_Adverse_Vechicle_Infromation()
        {
            Adverse1_LicensePlate = "";
            Edit_Adverse1_LicensePlate = "MH15 HJ 1001E";
            Adverse1_LicensePlateState = "";
            Edit_Adverse1_LicensePlateState = "WV";
            AD1_Vin_Year = "";
            Edit_AD1_Vin_Year = "";
            AD1_VIN_Make = "";
            Edit_AD1_VIN_Make = "";
            AD1_VIN_Model = "";
            Edit_AD1_VIN_Model = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Edit_Adverse_Vechicle_Infromation Instance
        {
            get { return instance; }
        }

#region Variables

        string _Adverse1_LicensePlate;

        /// <summary>
        /// Gets or sets the value of variable Adverse1_LicensePlate.
        /// </summary>
        [TestVariable("ad683533-16f5-46db-b477-9f3536070645")]
        public string Adverse1_LicensePlate
        {
            get { return _Adverse1_LicensePlate; }
            set { _Adverse1_LicensePlate = value; }
        }

        string _Edit_Adverse1_LicensePlate;

        /// <summary>
        /// Gets or sets the value of variable Edit_Adverse1_LicensePlate.
        /// </summary>
        [TestVariable("b63944af-5a54-4897-9839-c4a8107b86e9")]
        public string Edit_Adverse1_LicensePlate
        {
            get { return _Edit_Adverse1_LicensePlate; }
            set { _Edit_Adverse1_LicensePlate = value; }
        }

        string _Adverse1_LicensePlateState;

        /// <summary>
        /// Gets or sets the value of variable Adverse1_LicensePlateState.
        /// </summary>
        [TestVariable("cec5d2d3-b4b5-4f93-a255-0de77736c73c")]
        public string Adverse1_LicensePlateState
        {
            get { return _Adverse1_LicensePlateState; }
            set { _Adverse1_LicensePlateState = value; }
        }

        string _Edit_Adverse1_LicensePlateState;

        /// <summary>
        /// Gets or sets the value of variable Edit_Adverse1_LicensePlateState.
        /// </summary>
        [TestVariable("5a3a5de0-2680-45f2-9acf-0ceb21248f1e")]
        public string Edit_Adverse1_LicensePlateState
        {
            get { return _Edit_Adverse1_LicensePlateState; }
            set { _Edit_Adverse1_LicensePlateState = value; }
        }

        string _AD1_Vin_Year;

        /// <summary>
        /// Gets or sets the value of variable AD1_Vin_Year.
        /// </summary>
        [TestVariable("b6615c61-7419-4262-845e-39cc4050b566")]
        public string AD1_Vin_Year
        {
            get { return _AD1_Vin_Year; }
            set { _AD1_Vin_Year = value; }
        }

        string _Edit_AD1_Vin_Year;

        /// <summary>
        /// Gets or sets the value of variable Edit_AD1_Vin_Year.
        /// </summary>
        [TestVariable("3abe0f3f-615c-40dd-b5b0-38d4fa4128d2")]
        public string Edit_AD1_Vin_Year
        {
            get { return _Edit_AD1_Vin_Year; }
            set { _Edit_AD1_Vin_Year = value; }
        }

        string _AD1_VIN_Make;

        /// <summary>
        /// Gets or sets the value of variable AD1_VIN_Make.
        /// </summary>
        [TestVariable("1588ff7d-c299-46d6-ad59-f5efa7079540")]
        public string AD1_VIN_Make
        {
            get { return _AD1_VIN_Make; }
            set { _AD1_VIN_Make = value; }
        }

        string _Edit_AD1_VIN_Make;

        /// <summary>
        /// Gets or sets the value of variable Edit_AD1_VIN_Make.
        /// </summary>
        [TestVariable("44623f1c-81cc-43e9-bb3b-3a692dfa8520")]
        public string Edit_AD1_VIN_Make
        {
            get { return _Edit_AD1_VIN_Make; }
            set { _Edit_AD1_VIN_Make = value; }
        }

        string _AD1_VIN_Model;

        /// <summary>
        /// Gets or sets the value of variable AD1_VIN_Model.
        /// </summary>
        [TestVariable("3b19cb44-ff76-4a1c-af0a-ad61f9e35da2")]
        public string AD1_VIN_Model
        {
            get { return _AD1_VIN_Model; }
            set { _AD1_VIN_Model = value; }
        }

        string _Edit_AD1_VIN_Model;

        /// <summary>
        /// Gets or sets the value of variable Edit_AD1_VIN_Model.
        /// </summary>
        [TestVariable("f029a8be-eda5-406f-b1dd-a4e2f92419bb")]
        public string Edit_AD1_VIN_Model
        {
            get { return _Edit_AD1_VIN_Model; }
            set { _Edit_AD1_VIN_Model = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(0));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'ApplicationUnderTest.LabelTagNo1'.", repo.ApplicationUnderTest.LabelTagNo1Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.ApplicationUnderTest.LabelTagNo1Info, "Enabled", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$Adverse1_LicensePlate) on item 'ApplicationUnderTest.Adverse1_LicensePlate'.", repo.ApplicationUnderTest.Adverse1_LicensePlateInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.ApplicationUnderTest.Adverse1_LicensePlateInfo, "TagValue", Adverse1_LicensePlate);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", Adverse1_LicensePlate, new RecordItemIndex(3));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press.", new RecordItemIndex(4));
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press.", new RecordItemIndex(5));
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Edit_Adverse1_LicensePlate' with focus on 'ApplicationUnderTest.Adverse1_LicensePlate'.", repo.ApplicationUnderTest.Adverse1_LicensePlateInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.Adverse1_LicensePlate.PressKeys(Edit_Adverse1_LicensePlate);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$Adverse1_LicensePlateState) on item 'ApplicationUnderTest.Adverse1_LicensePlateState'.", repo.ApplicationUnderTest.Adverse1_LicensePlateStateInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.ApplicationUnderTest.Adverse1_LicensePlateStateInfo, "TagValue", Adverse1_LicensePlateState);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", Adverse1_LicensePlateState, new RecordItemIndex(8));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press.", new RecordItemIndex(9));
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press.", new RecordItemIndex(10));
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$Edit_Adverse1_LicensePlateState' on item 'ApplicationUnderTest.Adverse1_LicensePlateState'.", repo.ApplicationUnderTest.Adverse1_LicensePlateStateInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.Adverse1_LicensePlateState.Element.SetAttributeValue("TagValue", Edit_Adverse1_LicensePlateState);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$AD1_Vin_Year) on item 'ApplicationUnderTest.AD1_Vin_Year'.", repo.ApplicationUnderTest.AD1_Vin_YearInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AD1_Vin_YearInfo, "TagValue", AD1_Vin_Year);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", AD1_Vin_Year, new RecordItemIndex(13));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press.", new RecordItemIndex(14));
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press.", new RecordItemIndex(15));
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Edit_AD1_Vin_Year' with focus on 'ApplicationUnderTest.AD1_Vin_Year'.", repo.ApplicationUnderTest.AD1_Vin_YearInfo, new RecordItemIndex(16));
            repo.ApplicationUnderTest.AD1_Vin_Year.PressKeys(Edit_AD1_Vin_Year);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$AD1_VIN_Make) on item 'ApplicationUnderTest.AD1_VIN_Make'.", repo.ApplicationUnderTest.AD1_VIN_MakeInfo, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AD1_VIN_MakeInfo, "TagValue", AD1_VIN_Make);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", AD1_VIN_Make, new RecordItemIndex(18));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press.", new RecordItemIndex(19));
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press.", new RecordItemIndex(20));
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Edit_AD1_VIN_Make' with focus on 'ApplicationUnderTest.AD1_VIN_Make'.", repo.ApplicationUnderTest.AD1_VIN_MakeInfo, new RecordItemIndex(21));
            repo.ApplicationUnderTest.AD1_VIN_Make.PressKeys(Edit_AD1_VIN_Make);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$AD1_VIN_Model) on item 'ApplicationUnderTest.AD1_VIN_Model'.", repo.ApplicationUnderTest.AD1_VIN_ModelInfo, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AD1_VIN_ModelInfo, "TagValue", AD1_VIN_Model);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press.", new RecordItemIndex(23));
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press.", new RecordItemIndex(24));
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Edit_AD1_VIN_Model' with focus on 'ApplicationUnderTest.AD1_VIN_Model'.", repo.ApplicationUnderTest.AD1_VIN_ModelInfo, new RecordItemIndex(25));
            repo.ApplicationUnderTest.AD1_VIN_Model.PressKeys(Edit_AD1_VIN_Model);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(26));
            Delay.Duration(5000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", AD1_VIN_Model, repo.PegaCaseManagerPortalGoogleChrome.Screenshot_Window, false, new RecordItemIndex(27));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Save_Button' at 6;8.", repo.ApplicationUnderTest.Save_ButtonInfo, new RecordItemIndex(28));
            repo.ApplicationUnderTest.Save_Button.Click("6;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$Edit_Adverse1_LicensePlate) on item 'ApplicationUnderTest.Adverse1_LicensePlate'.", repo.ApplicationUnderTest.Adverse1_LicensePlateInfo, new RecordItemIndex(29));
            Validate.AttributeEqual(repo.ApplicationUnderTest.Adverse1_LicensePlateInfo, "TagValue", Edit_Adverse1_LicensePlate);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", Edit_Adverse1_LicensePlate, new RecordItemIndex(30));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$Edit_Adverse1_LicensePlateState) on item 'ApplicationUnderTest.Adverse1_LicensePlateState'.", repo.ApplicationUnderTest.Adverse1_LicensePlateStateInfo, new RecordItemIndex(31));
            Validate.AttributeEqual(repo.ApplicationUnderTest.Adverse1_LicensePlateStateInfo, "TagValue", Edit_Adverse1_LicensePlateState);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", Edit_Adverse1_LicensePlateState, new RecordItemIndex(32));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$Edit_AD1_Vin_Year) on item 'ApplicationUnderTest.AD1_Vin_Year'.", repo.ApplicationUnderTest.AD1_Vin_YearInfo, new RecordItemIndex(33));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AD1_Vin_YearInfo, "TagValue", Edit_AD1_Vin_Year);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", Edit_AD1_Vin_Year, new RecordItemIndex(34));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$Edit_AD1_VIN_Make) on item 'ApplicationUnderTest.AD1_VIN_Make'.", repo.ApplicationUnderTest.AD1_VIN_MakeInfo, new RecordItemIndex(35));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AD1_VIN_MakeInfo, "TagValue", Edit_AD1_VIN_Make);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", Edit_AD1_VIN_Make, new RecordItemIndex(36));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='yourtext') on item 'ApplicationUnderTest.AD1_VIN_Model'.", repo.ApplicationUnderTest.AD1_VIN_ModelInfo, new RecordItemIndex(37));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AD1_VIN_ModelInfo, "TagValue", "yourtext");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", Edit_AD1_VIN_Model, new RecordItemIndex(38));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Submit_3' at 52;13.", repo.ApplicationUnderTest.Submit_3Info, new RecordItemIndex(39));
            repo.ApplicationUnderTest.Submit_3.Click("52;13");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
