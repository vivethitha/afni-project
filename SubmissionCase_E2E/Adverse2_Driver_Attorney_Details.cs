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
    ///The Adverse2_Driver_Attorney_Details recording.
    /// </summary>
    [TestModule("c251cc70-a9d7-4b78-8ed0-0e6d8bdaa72f", ModuleType.Recording, 1)]
    public partial class Adverse2_Driver_Attorney_Details : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SubmissionCase_E2ERepository repository.
        /// </summary>
        public static SubmissionCase_E2ERepository repo = SubmissionCase_E2ERepository.Instance;

        static Adverse2_Driver_Attorney_Details instance = new Adverse2_Driver_Attorney_Details();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Adverse2_Driver_Attorney_Details()
        {
            AD2_Attorney_FirmName = "";
            AD2_Attorney_FirstName = "";
            AD2_Attorney_LastName = "";
            AD2_Attorney_Address1 = "";
            AD2_Attorney_Address2 = "";
            AD2_Attorney_City = "";
            AD2_Attorney_State = "";
            AD2_Attorney_Zip = "";
            AD2_Attorney_RepDate = "";
            AD2_AD_UseType = "";
            AD2_AD_PhoneType = "";
            AD2_AD_Source = "";
            AD2_AD_PhoneNumber = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Adverse2_Driver_Attorney_Details Instance
        {
            get { return instance; }
        }

#region Variables

        string _AD2_Attorney_FirmName;

        /// <summary>
        /// Gets or sets the value of variable AD2_Attorney_FirmName.
        /// </summary>
        [TestVariable("f88c7dbc-5db7-4ab0-b25c-4c6d7c6cbe91")]
        public string AD2_Attorney_FirmName
        {
            get { return _AD2_Attorney_FirmName; }
            set { _AD2_Attorney_FirmName = value; }
        }

        string _AD2_Attorney_FirstName;

        /// <summary>
        /// Gets or sets the value of variable AD2_Attorney_FirstName.
        /// </summary>
        [TestVariable("66f2d571-9554-47f9-ba51-20002dff8b3e")]
        public string AD2_Attorney_FirstName
        {
            get { return _AD2_Attorney_FirstName; }
            set { _AD2_Attorney_FirstName = value; }
        }

        string _AD2_Attorney_LastName;

        /// <summary>
        /// Gets or sets the value of variable AD2_Attorney_LastName.
        /// </summary>
        [TestVariable("c0c4e6af-9a55-4928-9635-6af6cd9ac216")]
        public string AD2_Attorney_LastName
        {
            get { return _AD2_Attorney_LastName; }
            set { _AD2_Attorney_LastName = value; }
        }

        string _AD2_Attorney_Address1;

        /// <summary>
        /// Gets or sets the value of variable AD2_Attorney_Address1.
        /// </summary>
        [TestVariable("326d0d26-cfdb-4cad-9049-9a53cf40739e")]
        public string AD2_Attorney_Address1
        {
            get { return _AD2_Attorney_Address1; }
            set { _AD2_Attorney_Address1 = value; }
        }

        string _AD2_Attorney_Address2;

        /// <summary>
        /// Gets or sets the value of variable AD2_Attorney_Address2.
        /// </summary>
        [TestVariable("b06f8611-a2b2-4224-bc48-3f650f6c654e")]
        public string AD2_Attorney_Address2
        {
            get { return _AD2_Attorney_Address2; }
            set { _AD2_Attorney_Address2 = value; }
        }

        string _AD2_Attorney_City;

        /// <summary>
        /// Gets or sets the value of variable AD2_Attorney_City.
        /// </summary>
        [TestVariable("d43224b1-e3bb-4141-b74a-74e780f0a302")]
        public string AD2_Attorney_City
        {
            get { return _AD2_Attorney_City; }
            set { _AD2_Attorney_City = value; }
        }

        string _AD2_Attorney_State;

        /// <summary>
        /// Gets or sets the value of variable AD2_Attorney_State.
        /// </summary>
        [TestVariable("71495b17-d82c-4693-b759-c9999908482a")]
        public string AD2_Attorney_State
        {
            get { return _AD2_Attorney_State; }
            set { _AD2_Attorney_State = value; }
        }

        string _AD2_Attorney_Zip;

        /// <summary>
        /// Gets or sets the value of variable AD2_Attorney_Zip.
        /// </summary>
        [TestVariable("cb1e4047-6d42-4d4e-b087-a7d737442d68")]
        public string AD2_Attorney_Zip
        {
            get { return _AD2_Attorney_Zip; }
            set { _AD2_Attorney_Zip = value; }
        }

        string _AD2_Attorney_RepDate;

        /// <summary>
        /// Gets or sets the value of variable AD2_Attorney_RepDate.
        /// </summary>
        [TestVariable("157883a8-d55e-4db6-8cd8-151954d8e2b5")]
        public string AD2_Attorney_RepDate
        {
            get { return _AD2_Attorney_RepDate; }
            set { _AD2_Attorney_RepDate = value; }
        }

        string _AD2_AD_UseType;

        /// <summary>
        /// Gets or sets the value of variable AD2_AD_UseType.
        /// </summary>
        [TestVariable("13c0a320-86ba-485d-aa51-518ec4d010af")]
        public string AD2_AD_UseType
        {
            get { return _AD2_AD_UseType; }
            set { _AD2_AD_UseType = value; }
        }

        string _AD2_AD_PhoneType;

        /// <summary>
        /// Gets or sets the value of variable AD2_AD_PhoneType.
        /// </summary>
        [TestVariable("0a4a14a7-2583-4d46-8b41-a58c8847dcf8")]
        public string AD2_AD_PhoneType
        {
            get { return _AD2_AD_PhoneType; }
            set { _AD2_AD_PhoneType = value; }
        }

        string _AD2_AD_Source;

        /// <summary>
        /// Gets or sets the value of variable AD2_AD_Source.
        /// </summary>
        [TestVariable("6de28a5a-9c41-4a9c-ae51-a6ef8fc14892")]
        public string AD2_AD_Source
        {
            get { return _AD2_AD_Source; }
            set { _AD2_AD_Source = value; }
        }

        string _AD2_AD_PhoneNumber;

        /// <summary>
        /// Gets or sets the value of variable AD2_AD_PhoneNumber.
        /// </summary>
        [TestVariable("53d7b817-5f07-42ae-9940-c23c1a8300e9")]
        public string AD2_AD_PhoneNumber
        {
            get { return _AD2_AD_PhoneNumber; }
            set { _AD2_AD_PhoneNumber = value; }
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

        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
