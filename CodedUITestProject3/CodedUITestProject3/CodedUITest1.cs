using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls; //need add


namespace CodedUITestProject3
{
    /// <resumo>
    /// Descrição resumida para CodedUITest1
    /// </resumo>
    [CodedUITest]
    public class CodedUITest1
    {
        public CodedUITest1()
        {
        }

        [TestMethod]
        public void CodedUITestMethod1()
        {
            ApplicationUnderTest.Launch(@"C:\Users\Eduardo Felizardo\Documents\Projeto Citrix\CodedUITestProject3\Software para teste\SetupVerifyCS.exe");
            WinWindow winWindow = new WinWindow();
            winWindow.SearchProperties[WinWindow.PropertyNames.Name] = "CheckSetup";

            //Button click verify
            WinWindow ButtonWindows = new WinWindow(winWindow);
            ButtonWindows.SearchProperties[WinWindow.PropertyNames.Name] = "Verify";
            ButtonWindows.SearchProperties[WinWindow.PropertyNames.ControlType] = "Button";
            Mouse.Click(ButtonWindows);
            Playback.Wait(3500);

            //Message
            WinWindow MessageSetup = new WinWindow(winWindow);
            MessageSetup.SearchProperties[WinWindow.PropertyNames.ControlType] = "Text";

            WinWindow MessageSetupVerify = new WinWindow(winWindow);
            MessageSetupVerify.SearchProperties[WinWindow.PropertyNames.ControlName] = "Oh! You are missing some required softwares!";

            //Button close
            WinWindow ButtonClose = new WinWindow(winWindow);
            ButtonClose.SearchProperties[WinWindow.PropertyNames.Name] = "Close";
            ButtonClose.SearchProperties[WinWindow.PropertyNames.ControlType] = "Button";
            Mouse.Click(ButtonClose);
            Playback.Wait(5000);
        }

        [TestMethod]
        public void CodedUITestMethod2()
        {
            ApplicationUnderTest.Launch(@"C:\Users\Eduardo Felizardo\Documents\Projeto Citrix\CodedUITestProject3\Software para teste\SetupVerifyCS.exe");
            WinWindow winWindow = new WinWindow();
            winWindow.SearchProperties[WinWindow.PropertyNames.Name] = "CheckSetup";

            Playback.Wait(2500);

            //Button close
            WinWindow ButtonClose = new WinWindow(winWindow);
            ButtonClose.SearchProperties[WinWindow.PropertyNames.Name] = "Check Setup Environment";
            ButtonClose.SearchProperties[WinWindow.PropertyNames.ControlType] = "Button";
            Mouse.Click(ButtonClose);
            Playback.Wait(5000);
        }

        [TestMethod]
        public void CodedUITestMethod3()
        {
            ApplicationUnderTest.Launch(@"C:\Users\Eduardo Felizardo\Documents\Projeto Citrix\CodedUITestProject3\Software para teste\SetupVerifyCS.exe");
            WinWindow winWindow = new WinWindow();
            winWindow.SearchProperties[WinWindow.PropertyNames.Name] = "CheckSetup";

            Playback.Wait(2500);

            //Button Minimized
            WinWindow ButtonMinimized = new WinWindow(winWindow);
            ButtonMinimized.SearchProperties[WinWindow.PropertyNames.Name] = "";
            ButtonMinimized.SearchProperties[WinWindow.PropertyNames.ControlType] = "Button";
            Mouse.Click(ButtonMinimized);

            Playback.Wait(2500);

            //Button close
            WinWindow ButtonClose = new WinWindow(winWindow);
            ButtonClose.SearchProperties[WinWindow.PropertyNames.Name] = "Close";
            ButtonClose.SearchProperties[WinWindow.PropertyNames.ControlType] = "Button";
            Playback.Wait(5000);
            Mouse.Click(ButtonClose);
        }

        #region Atributos de teste adicionais

        // É possível usar os seguintes atributos adicionais enquanto escreve os testes:

        ////Use TestInitialize para executar código antes de executar cada teste 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // Para gerar código para este teste, selecione "Gerar Código para Teste de Interface do Usuário Codificado" no menu de atalho e selecione um dos itens do menu.
        //}

        ////Use TestCleanup para executar código depois de cada execução de teste
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // Para gerar código para este teste, selecione "Gerar Código para Teste de Interface do Usuário Codificado" no menu de atalho e selecione um dos itens do menu.
        //}

        #endregion

        /// <resumo>
        ///Obtém ou define o contexto do teste que provê
        ///informação e funcionalidade da execução de teste atual.
        ///</resumo>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if (this.map == null)
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
