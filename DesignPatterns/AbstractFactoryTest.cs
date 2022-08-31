using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class AbstractFactoryTest
    {
        private readonly IGUIFactory _guiFactory;

        private IButton _button;
        public AbstractFactoryTest(IGUIFactory gUIFactory)
        {
            _guiFactory = gUIFactory;
        }

        public void CreateUI() 
        {
            _button = _guiFactory.CreateButton();
        }

        public void Paint()
        {
            _button.Paint();
        }

    }


    public interface IGUIFactory 
    {
        public IButton CreateButton();
        public ICheckBox CreateCheckBox();
    }

    public class WinGUIFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }

        public ICheckBox CreateCheckBox()
        {
            return new WinCheckBox();
        }
    }

    public class MacGUIFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckBox CreateCheckBox()
        {
            return new MacCheckBox();
        }
    }


    public interface IButton {
        void Paint();
    }

    public class WinButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("This is WinButton's paint");
        }
    }

    public class MacButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("This is MacButton's paint");
        }
    }


    public interface ICheckBox
    {
        void Paint();
    }

    public class WinCheckBox : ICheckBox
    {
        public void Paint()
        {
            Console.WriteLine("This is WinCheckBox's paint");
        }
    }

    public class MacCheckBox : ICheckBox
    {
        public void Paint()
        {
            Console.WriteLine("This is MacCheckBox's paint");
        }
    }

}
