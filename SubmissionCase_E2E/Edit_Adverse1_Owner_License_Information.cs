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
    ///The Edit_Adverse1_Owner_License_Information recording.
    /// </summary>
    [TestModule("466b1cb2-0ca5-4820-8105-a8ac18eb2e56", ModuleType.Recording, 1)]
    public partial class Edit_Adverse1_Owner_License_Information : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SubmissionCase_E2ERepository repository.
        /// </summary>
        public static SubmissionCase_E2ERepository repo = SubmissionCase_E2ERepository.Instance;

        static Edit_Adverse1_Owner_License_Information instance = new Edit_Adverse1_Owner_License_Information();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Edit_Adverse1_Owner_License_Information()
        {
            AO_LI_SSN = "";
            Edit_AO_LI_SSN = "E12345SSN1";
            AO_LI_DateOfBirth_getValue = "";
            Edit_AO_LI_DateOfBirth_getValue = "3/5/1994";
            AO_LI_LicenseNumber = "";
            Edit_AO_LI_LicenseNumber = "ELICNO123";
            AO_LI_LicenseState = "";
            Edit_AO_LI_LicenseState = "UT";
            AO_LI_RevocationDate_getValue = "";
            Edit_AO_LI_RevocationDate_getValue = "7/8/2018";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Edit_Adverse1_Owner_License_Information Instance
        {
            get { return instance; }
        }

#region Variables

        string _AO_LI_SSN;

        /// <summary>
        /// Gets or sets the value of variable AO_LI_SSN.
        /// </summary>
        [TestVariable("8b13e696-1ffa-4b0b-9099-ec67db8e669a")]
        public string AO_LI_SSN
        {
            get { return _AO_LI_SSN; }
            set { _AO_LI_SSN = value; }
        }

        string _Edit_AO_LI_SSN;

        /// <summary>
        /// Gets or sets the value of variable Edit_AO_LI_SSN.
        /// </summary>
        [TestVariable("36d874f0-3d0d-4397-be48-4559725767c2")]
        public string Edit_AO_LI_SSN
        {
            get { return _Edit_AO_LI_SSN; }
            set { _Edit_AO_LI_SSN = value; }
        }

        string _AO_LI_DateOfBirth_getValue;

        /// <summary>
        /// Gets or sets the value of variable AO_LI_DateOfBirth_getValue.
        /// </summary>
        [TestVariable("b1cadcac-03aa-4882-b288-3b90008bdd80")]
        public string AO_LI_DateOfBirth_getValue
        {
            get { return _AO_LI_DateOfBirth_getValue; }
            set { _AO_LI_DateOfBirth_getValue = value; }
        }

        string _Edit_AO_LI_DateOfBirth_getValue;

        /// <summary>
        /// Gets or sets the value of variable Edit_AO_LI_DateOfBirth_getValue.
        /// </summary>
        [TestVariable("62feddb1-c21e-4ed6-baa7-d76f51613a1f")]
        public string Edit_AO_LI_DateOfBirth_getValue
        {
            get { return _Edit_AO_LI_DateOfBirth_getValue; }
            set { _Edit_AO_LI_DateOfBirth_getValue = value; }
        }

        string _AO_LI_LicenseNumber;

        /// <summary>
        /// Gets or sets the value of variable AO_LI_LicenseNumber.
        /// </summary>
        [TestVariable("8b1cb885-c6c8-48a9-b28f-101f55029c10")]
        public string AO_LI_LicenseNumber
        {
            get { return _AO_LI_LicenseNumber; }
            set { _AO_LI_LicenseNumber = value; }
        }

        string _Edit_AO_LI_LicenseNumber;

        /// <summary>
        /// Gets or sets the value of variable Edit_AO_LI_LicenseNumber.
        /// </summary>
        [TestVariable("e15b37e1-d327-4da1-91f5-8c53eeeeccb5")]
        public string Edit_AO_LI_LicenseNumber
        {
            get { return _Edit_AO_LI_LicenseNumber; }
            set { _Edit_AO_LI_LicenseNumber = value; }
        }

        string _AO_LI_LicenseState;

        /// <summary>
        /// Gets or sets the value of variable AO_LI_LicenseState.
        /// </summary>
        [TestVariable("7884e978-4f38-4148-8a43-d70a5529c3f9")]
        public string AO_LI_LicenseState
        {
            get { return _AO_LI_LicenseState; }
            set { _AO_LI_LicenseState = value; }
        }

        string _Edit_AO_LI_LicenseState;

        /// <summary>
        /// Gets or sets the value of variable Edit_AO_LI_LicenseState.
        /// </summary>
        [TestVariable("b7b4005b-894b-4c1a-840a-9c2b2c96976f")]
        public string Edit_AO_LI_LicenseState
        {
            get { return _Edit_AO_LI_LicenseState; }
            set { _Edit_AO_LI_LicenseState = value; }
        }

        string _AO_LI_RevocationDate_getValue;

        /// <summary>
        /// Gets or sets the value of variable AO_LI_RevocationDate_getValue.
        /// </summary>
        [TestVariable("953cf537-bffd-4e88-b589-21cfc6f0b757")]
        public string AO_LI_RevocationDate_getValue
        {
            get { return _AO_LI_RevocationDate_getValue; }
            set { _AO_LI_RevocationDate_getValue = value; }
        }

        string _Edit_AO_LI_RevocationDate_getValue;

        /// <summary>
        /// Gets or sets the value of variable Edit_AO_LI_RevocationDate_getValue.
        /// </summary>
        [TestVariable("2406ef06-9ba7-4377-9fed-05905edebdeb")]
        public string Edit_AO_LI_RevocationDate_getValue
        {
            get { return _Edit_AO_LI_RevocationDate_getValue; }
            set { _Edit_AO_LI_RevocationDate_getValue = value; }
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
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='O_Employment Place') on item 'ApplicationUnderTest.AO_LI_EmploymentPlace'.", repo.ApplicationUnderTest.AO_LI_EmploymentPlaceInfo, new RecordItemIndex(2));
            //Validate.AttributeEqual(repo.ApplicationUnderTest.AO_LI_EmploymentPlaceInfo, "TagValue", "O_Employment Place");
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'ApplicationUnderTest.AO_LI_SSN' and assigning its value to variable 'AO_LI_SSN'.", repo.ApplicationUnderTest.AO_LI_SSNInfo, new RecordItemIndex(3));
            AO_LI_SSN = repo.ApplicationUnderTest.AO_LI_SSN.Element.GetAttributeValueText("TagValue");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$AO_LI_SSN) on item 'ApplicationUnderTest.AO_LI_SSN'.", repo.ApplicationUnderTest.AO_LI_SSNInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AO_LI_SSNInfo, "TagValue", AO_LI_SSN);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", AO_LI_SSN, new RecordItemIndex(5));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press.", new RecordItemIndex(6));
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press.", new RecordItemIndex(7));
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Edit_AO_LI_SSN' with focus on 'ApplicationUnderTest.AO_LI_SSN'.", repo.ApplicationUnderTest.AO_LI_SSNInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.AO_LI_SSN.PressKeys(Edit_AO_LI_SSN);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'ApplicationUnderTest.AO_LI_DateOfBirth' and assigning its value to variable 'AO_LI_DateOfBirth_getValue'.", repo.ApplicationUnderTest.AO_LI_DateOfBirthInfo, new RecordItemIndex(9));
            AO_LI_DateOfBirth_getValue = repo.ApplicationUnderTest.AO_LI_DateOfBirth.Element.GetAttributeValueText("TagValue");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", AO_LI_DateOfBirth_getValue, new RecordItemIndex(10));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$AO_LI_DateOfBirth_getValue) on item 'ApplicationUnderTest.AO_LI_DateOfBirth'.", repo.ApplicationUnderTest.AO_LI_DateOfBirthInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AO_LI_DateOfBirthInfo, "TagValue", AO_LI_DateOfBirth_getValue);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press.", new RecordItemIndex(12));
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press.", new RecordItemIndex(13));
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Edit_AO_LI_DateOfBirth_getValue' with focus on 'ApplicationUnderTest.AO_LI_DateOfBirth'.", repo.ApplicationUnderTest.AO_LI_DateOfBirthInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.AO_LI_DateOfBirth.PressKeys(Edit_AO_LI_DateOfBirth_getValue);
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'ApplicationUnderTest.AO_LI_LicenseNumber' and assigning its value to variable 'AO_LI_LicenseNumber'.", repo.ApplicationUnderTest.AO_LI_LicenseNumberInfo, new RecordItemIndex(15));
            //AO_LI_LicenseNumber = repo.ApplicationUnderTest.AO_LI_LicenseNumber.Element.GetAttributeValueText("TagValue");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$AO_LI_LicenseNumber) on item 'ApplicationUnderTest.AO_LI_LicenseNumber'.", repo.ApplicationUnderTest.AO_LI_LicenseNumberInfo, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AO_LI_LicenseNumberInfo, "TagValue", AO_LI_LicenseNumber);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", AO_LI_LicenseNumber, new RecordItemIndex(17));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press.", new RecordItemIndex(18));
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press.", new RecordItemIndex(19));
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Edit_AO_LI_LicenseNumber' with focus on 'ApplicationUnderTest.AO_LI_LicenseNumber'.", repo.ApplicationUnderTest.AO_LI_LicenseNumberInfo, new RecordItemIndex(20));
            repo.ApplicationUnderTest.AO_LI_LicenseNumber.PressKeys(Edit_AO_LI_LicenseNumber);
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'ApplicationUnderTest.AO_LI_LicenseState' and assigning its value to variable 'AO_LI_LicenseState'.", repo.ApplicationUnderTest.AO_LI_LicenseStateInfo, new RecordItemIndex(21));
            //AO_LI_LicenseState = repo.ApplicationUnderTest.AO_LI_LicenseState.Element.GetAttributeValueText("TagValue");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$AO_LI_LicenseState) on item 'ApplicationUnderTest.AO_LI_LicenseState'.", repo.ApplicationUnderTest.AO_LI_LicenseStateInfo, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AO_LI_LicenseStateInfo, "TagValue", AO_LI_LicenseState);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", AO_LI_LicenseState, new RecordItemIndex(23));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press.", new RecordItemIndex(24));
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press.", new RecordItemIndex(25));
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Edit_AO_LI_LicenseState' with focus on 'ApplicationUnderTest.AO_LI_LicenseState'.", repo.ApplicationUnderTest.AO_LI_LicenseStateInfo, new RecordItemIndex(26));
            repo.ApplicationUnderTest.AO_LI_LicenseState.PressKeys(Edit_AO_LI_LicenseState);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'ApplicationUnderTest.AO_LI_RevocationDate' and assigning its value to variable 'AO_LI_RevocationDate_getValue'.", repo.ApplicationUnderTest.AO_LI_RevocationDateInfo, new RecordItemIndex(27));
            AO_LI_RevocationDate_getValue = repo.ApplicationUnderTest.AO_LI_RevocationDate.Element.GetAttributeValueText("TagValue");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$AO_LI_RevocationDate_getValue) on item 'ApplicationUnderTest.AO_LI_RevocationDate'.", repo.ApplicationUnderTest.AO_LI_RevocationDateInfo, new RecordItemIndex(28));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AO_LI_RevocationDateInfo, "TagValue", AO_LI_RevocationDate_getValue);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", AO_LI_RevocationDate_getValue, new RecordItemIndex(29));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press.", new RecordItemIndex(30));
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press.", new RecordItemIndex(31));
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Edit_AO_LI_RevocationDate_getValue' with focus on 'ApplicationUnderTest.AO_LI_RevocationDate'.", repo.ApplicationUnderTest.AO_LI_RevocationDateInfo, new RecordItemIndex(32));
            repo.ApplicationUnderTest.AO_LI_RevocationDate.PressKeys(Edit_AO_LI_RevocationDate_getValue);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'ApplicationUnderTest.AO_LI_Revoked'.", repo.ApplicationUnderTest.AO_LI_RevokedInfo, new RecordItemIndex(33));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AO_LI_RevokedInfo, "Checked", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='true') on item 'ApplicationUnderTest.AO_LI_Revoked'.", repo.ApplicationUnderTest.AO_LI_RevokedInfo, new RecordItemIndex(34));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AO_LI_RevokedInfo, "Value", "true");
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.PegaCaseManagerPortalGoogleChrome.Screenshot_Window, false, new RecordItemIndex(35));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Save_Button' at 6;8.", repo.ApplicationUnderTest.Save_ButtonInfo, new RecordItemIndex(36));
            repo.ApplicationUnderTest.Save_Button.Click("6;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(37));
            Delay.Duration(5000, false);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='O_Employment Place') on item 'ApplicationUnderTest.AO_LI_EmploymentPlace'.", repo.ApplicationUnderTest.AO_LI_EmploymentPlaceInfo, new RecordItemIndex(38));
            //Validate.AttributeEqual(repo.ApplicationUnderTest.AO_LI_EmploymentPlaceInfo, "TagValue", "O_Employment Place");
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$Edit_AO_LI_SSN) on item 'ApplicationUnderTest.AO_LI_SSN'.", repo.ApplicationUnderTest.AO_LI_SSNInfo, new RecordItemIndex(39));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AO_LI_SSNInfo, "InnerText", Edit_AO_LI_SSN);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", Edit_AO_LI_SSN, new RecordItemIndex(40));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$Edit_AO_LI_DateOfBirth_getValue) on item 'ApplicationUnderTest.AO_LI_DateOfBirth'.", repo.ApplicationUnderTest.AO_LI_DateOfBirthInfo, new RecordItemIndex(41));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AO_LI_DateOfBirthInfo, "InnerText", Edit_AO_LI_DateOfBirth_getValue);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", Edit_AO_LI_DateOfBirth_getValue, new RecordItemIndex(42));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$Edit_AO_LI_LicenseNumber) on item 'ApplicationUnderTest.AO_LI_LicenseNumber'.", repo.ApplicationUnderTest.AO_LI_LicenseNumberInfo, new RecordItemIndex(43));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AO_LI_LicenseNumberInfo, "InnerText", Edit_AO_LI_LicenseNumber);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", Edit_AO_LI_LicenseNumber, new RecordItemIndex(44));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$Edit_AO_LI_LicenseState) on item 'ApplicationUnderTest.AO_LI_LicenseState'.", repo.ApplicationUnderTest.AO_LI_LicenseStateInfo, new RecordItemIndex(45));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AO_LI_LicenseStateInfo, "InnerText", Edit_AO_LI_LicenseState);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", Edit_AO_LI_LicenseState, new RecordItemIndex(46));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$Edit_AO_LI_RevocationDate_getValue) on item 'ApplicationUnderTest.AO_LI_RevocationDate'.", repo.ApplicationUnderTest.AO_LI_RevocationDateInfo, new RecordItemIndex(47));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AO_LI_RevocationDateInfo, "InnerText", Edit_AO_LI_RevocationDate_getValue);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", Edit_AO_LI_RevocationDate_getValue, new RecordItemIndex(48));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SubmitButton1' at 46;15.", repo.ApplicationUnderTest.SubmitButton1Info, new RecordItemIndex(49));
            repo.ApplicationUnderTest.SubmitButton1.Click("46;15");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
