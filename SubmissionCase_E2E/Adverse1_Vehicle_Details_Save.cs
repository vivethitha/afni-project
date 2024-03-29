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
    ///The Adverse1_Vehicle_Details_Save recording.
    /// </summary>
    [TestModule("9fd75697-fd09-496f-922e-e316972e8d85", ModuleType.Recording, 1)]
    public partial class Adverse1_Vehicle_Details_Save : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SubmissionCase_E2ERepository repository.
        /// </summary>
        public static SubmissionCase_E2ERepository repo = SubmissionCase_E2ERepository.Instance;

        static Adverse1_Vehicle_Details_Save instance = new Adverse1_Vehicle_Details_Save();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Adverse1_Vehicle_Details_Save()
        {
            Adverse1_LicensePlate = "";
            Adverse1_LicensePlateState = "";
            AD1_Vin_Year = "";
            AD1_VIN_Make = "";
            AD1_VIN_Model = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Adverse1_Vehicle_Details_Save Instance
        {
            get { return instance; }
        }

#region Variables

        string _Adverse1_LicensePlate;

        /// <summary>
        /// Gets or sets the value of variable Adverse1_LicensePlate.
        /// </summary>
        [TestVariable("acb91ecb-a0e2-418a-9f1b-b547d54fe765")]
        public string Adverse1_LicensePlate
        {
            get { return _Adverse1_LicensePlate; }
            set { _Adverse1_LicensePlate = value; }
        }

        string _Adverse1_LicensePlateState;

        /// <summary>
        /// Gets or sets the value of variable Adverse1_LicensePlateState.
        /// </summary>
        [TestVariable("71f80b98-f9df-483c-884f-db706de45fc0")]
        public string Adverse1_LicensePlateState
        {
            get { return _Adverse1_LicensePlateState; }
            set { _Adverse1_LicensePlateState = value; }
        }

        string _AD1_Vin_Year;

        /// <summary>
        /// Gets or sets the value of variable AD1_Vin_Year.
        /// </summary>
        [TestVariable("9fbd4b4c-cc70-4998-88e7-ebf6af984a31")]
        public string AD1_Vin_Year
        {
            get { return _AD1_Vin_Year; }
            set { _AD1_Vin_Year = value; }
        }

        string _AD1_VIN_Make;

        /// <summary>
        /// Gets or sets the value of variable AD1_VIN_Make.
        /// </summary>
        [TestVariable("ab68bf9e-2ca5-4d83-b394-a43b8e93d4c6")]
        public string AD1_VIN_Make
        {
            get { return _AD1_VIN_Make; }
            set { _AD1_VIN_Make = value; }
        }

        string _AD1_VIN_Model;

        /// <summary>
        /// Gets or sets the value of variable AD1_VIN_Model.
        /// </summary>
        [TestVariable("de63e140-fa5d-43d0-bdb5-0fa1dddc71c2")]
        public string AD1_VIN_Model
        {
            get { return _AD1_VIN_Model; }
            set { _AD1_VIN_Model = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Save_Button' at 6;8.", repo.ApplicationUnderTest.Save_ButtonInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.Save_Button.Click("6;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(1));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'ApplicationUnderTest.LabelTagNo1'.", repo.ApplicationUnderTest.LabelTagNo1Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.ApplicationUnderTest.LabelTagNo1Info, "Enabled", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$Adverse1_LicensePlate) on item 'ApplicationUnderTest.Adverse1_LicensePlate'.", repo.ApplicationUnderTest.Adverse1_LicensePlateInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.ApplicationUnderTest.Adverse1_LicensePlateInfo, "TagValue", Adverse1_LicensePlate);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", Adverse1_LicensePlate, new RecordItemIndex(4));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$Adverse1_LicensePlateState) on item 'ApplicationUnderTest.Adverse1_LicensePlateState'.", repo.ApplicationUnderTest.Adverse1_LicensePlateStateInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.ApplicationUnderTest.Adverse1_LicensePlateStateInfo, "TagValue", Adverse1_LicensePlateState);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", Adverse1_LicensePlateState, new RecordItemIndex(6));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$AD1_Vin_Year) on item 'ApplicationUnderTest.AD1_Vin_Year'.", repo.ApplicationUnderTest.AD1_Vin_YearInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AD1_Vin_YearInfo, "TagValue", AD1_Vin_Year);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", AD1_Vin_Year, new RecordItemIndex(8));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$AD1_VIN_Make) on item 'ApplicationUnderTest.AD1_VIN_Make'.", repo.ApplicationUnderTest.AD1_VIN_MakeInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AD1_VIN_MakeInfo, "TagValue", AD1_VIN_Make);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", AD1_VIN_Make, new RecordItemIndex(10));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$AD1_VIN_Model) on item 'ApplicationUnderTest.AD1_VIN_Model'.", repo.ApplicationUnderTest.AD1_VIN_ModelInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AD1_VIN_ModelInfo, "TagValue", AD1_VIN_Model);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", AD1_VIN_Model, repo.PegaCaseManagerPortalGoogleChrome.Screenshot_Window, false, new RecordItemIndex(12));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Submit_3' at 52;13.", repo.ApplicationUnderTest.Submit_3Info, new RecordItemIndex(13));
            repo.ApplicationUnderTest.Submit_3.Click("52;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(14));
            Delay.Duration(5000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
