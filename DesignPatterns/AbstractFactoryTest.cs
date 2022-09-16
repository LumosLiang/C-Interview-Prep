using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class AbstractFactoryTest
    {
        private readonly IGUIFactory _guiFactory;

        private IButton _button;
        private ICheckBox _checkbox;
        public AbstractFactoryTest(IGUIFactory gUIFactory)
        {
            _guiFactory = gUIFactory;
        }

        public void CreateUI() 
        {
            _button = _guiFactory.CreateButton();
            _checkbox = _guiFactory.CreateCheckBox();
        }

        public void Paint()
        {
            _button.Paint();
            _checkbox.Paint();
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
        void Collorate(IButton button);
    }

    public class WinCheckBox : ICheckBox
    {

        public void Paint()
        {
            Console.WriteLine("This is WinCheckBox's paint");
        }
        public void Collorate(IButton button)
        {
            throw new NotImplementedException();
        }

    }

    public class MacCheckBox : ICheckBox
    {
        public void Paint()
        {
            Console.WriteLine("This is MacCheckBox's paint");
        }
        public void Collorate(IButton button)
        {
            throw new NotImplementedException();
        }

    }

}
