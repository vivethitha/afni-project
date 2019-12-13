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
    ///The InsuredDetails_Vehicle_Information recording.
    /// </summary>
    [TestModule("a83c2f1e-a2a6-4806-a724-e1e4a5c7de17", ModuleType.Recording, 1)]
    public partial class InsuredDetails_Vehicle_Information : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SubmissionCase_E2ERepository repository.
        /// </summary>
        public static SubmissionCase_E2ERepository repo = SubmissionCase_E2ERepository.Instance;

        static InsuredDetails_Vehicle_Information instance = new InsuredDetails_Vehicle_Information();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InsuredDetails_Vehicle_Information()
        {
            ID_VI_LicensePlate = "";
            ID_VI_LicensePlateState = "";
            ID_VD_Vin_Year = "";
            ID_VD_VIN_Make = "";
            ID_VD_VIN_Model = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InsuredDetails_Vehicle_Information Instance
        {
            get { return instance; }
        }

#region Variables

        string _ID_VI_LicensePlate;

        /// <summary>
        /// Gets or sets the value of variable ID_VI_LicensePlate.
        /// </summary>
        [TestVariable("88725ee8-5a16-4bb7-b6cb-c8e798562ae2")]
        public string ID_VI_LicensePlate
        {
            get { return _ID_VI_LicensePlate; }
            set { _ID_VI_LicensePlate = value; }
        }

        string _ID_VI_LicensePlateState;

        /// <summary>
        /// Gets or sets the value of variable ID_VI_LicensePlateState.
        /// </summary>
        [TestVariable("ad2e8084-3ec1-4a24-b458-3beeb6332a34")]
        public string ID_VI_LicensePlateState
        {
            get { return _ID_VI_LicensePlateState; }
            set { _ID_VI_LicensePlateState = value; }
        }

        string _ID_VD_Vin_Year;

        /// <summary>
        /// Gets or sets the value of variable ID_VD_Vin_Year.
        /// </summary>
        [TestVariable("65e33aa0-de45-4842-9efc-84e1b3efa107")]
        public string ID_VD_Vin_Year
        {
            get { return _ID_VD_Vin_Year; }
            set { _ID_VD_Vin_Year = value; }
        }

        string _ID_VD_VIN_Make;

        /// <summary>
        /// Gets or sets the value of variable ID_VD_VIN_Make.
        /// </summary>
        [TestVariable("ec383190-7e50-467a-a036-5f147936188c")]
        public string ID_VD_VIN_Make
        {
            get { return _ID_VD_VIN_Make; }
            set { _ID_VD_VIN_Make = value; }
        }

        string _ID_VD_VIN_Model;

        /// <summary>
        /// Gets or sets the value of variable ID_VD_VIN_Model.
        /// </summary>
        [TestVariable("eb83a837-374b-42ee-9a37-9e2830625754")]
        public string ID_VD_VIN_Model
        {
            get { return _ID_VD_VIN_Model; }
            set { _ID_VD_VIN_Model = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'ApplicationUnderTest.ID_VI_Header'", repo.ApplicationUnderTest.ID_VI_HeaderInfo, new ActionTimeout(10000), new RecordItemIndex(0));
            repo.ApplicationUnderTest.ID_VI_HeaderInfo.WaitForExists(10000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ID_VI_LicensePlate' with focus on 'ApplicationUnderTest.ID_VI_LicensePlate'.", repo.ApplicationUnderTest.ID_VI_LicensePlateInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.ID_VI_LicensePlate.PressKeys(ID_VI_LicensePlate);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$ID_VI_LicensePlateState' on item 'ApplicationUnderTest.ID_VI_LicensePlateState'.", repo.ApplicationUnderTest.ID_VI_LicensePlateStateInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.ID_VI_LicensePlateState.Element.SetAttributeValue("TagValue", ID_VI_LicensePlateState);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$ID_VD_Vin_Year' on item 'ApplicationUnderTest.ID_VD_Vin_Year'.", repo.ApplicationUnderTest.ID_VD_Vin_YearInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.ID_VD_Vin_Year.Element.SetAttributeValue("TagValue", ID_VD_Vin_Year);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ID_VD_VIN_Make' at Center.", repo.ApplicationUnderTest.ID_VD_VIN_MakeInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.ID_VD_VIN_Make.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ID_VD_VIN_Make' with focus on 'ApplicationUnderTest.ID_VD_VIN_Make'.", repo.ApplicationUnderTest.ID_VD_VIN_MakeInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.ID_VD_VIN_Make.PressKeys(ID_VD_VIN_Make);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(6));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}'.", new RecordItemIndex(7));
            Keyboard.Press("{Down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'ApplicationUnderTest.ID_VD_VIN_Make_Volkswagen' at Center.", repo.ApplicationUnderTest.ID_VD_VIN_Make_VolkswagenInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.ID_VD_VIN_Make_Volkswagen.DoubleClick();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(9));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(10));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Manual_Model_Details' at Center.", repo.ApplicationUnderTest.Manual_Model_DetailsInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.Manual_Model_Details.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ID_VD_VIN_Model' with focus on 'ApplicationUnderTest.ID_VD_VIN_Make_Volkswagen'.", repo.ApplicationUnderTest.ID_VD_VIN_Make_VolkswagenInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.ID_VD_VIN_Make_Volkswagen.PressKeys(ID_VD_VIN_Model);
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.PegaCaseManagerPortalGoogleChrome.Screenshot_Window, false, new RecordItemIndex(13));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}