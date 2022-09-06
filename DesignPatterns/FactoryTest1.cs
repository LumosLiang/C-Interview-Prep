using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{

    public class FactoryTest1 { 

    }

    public abstract class CreditCard {

        public abstract string CardType { get; }
        public abstract int CreditLimit { get; }
        public abstract void SetCreditLimit(int limit);
        public abstract void GetCardInformation();

    }

    public class MasterCreditCard : CreditCard
    {

        private readonly string _cardType;

        private int _creditLimit;

        public override string CardType {
            get {
                return _cardType;
            }
        }

        public override int CreditLimit
        {
            get
            {
                return _creditLimit;
            }
        }

        public override void GetCardInformation()
        {
            Console.WriteLine($"CardType: {_cardType}, CreditLimit: {_creditLimit}"); ;
        }

        public override void SetCreditLimit(int limit)
        {
            _creditLimit = limit;
        }

        public MasterCreditCard(int InitialLimit)
        {
            _creditLimit = InitialLimit;
            _cardType = "Master";
        }
    }

    public class VisaCreditCard : CreditCard
    {
        private readonly string _cardType;
        private int _creditLimit;
        public override string CardType
        {
            get
            {
                return _cardType;
            }
        }
        public override int CreditLimit
        {
            get
            {
                return _creditLimit;
            }
        }
        public override void GetCardInformation()
        {
            Console.WriteLine($"CardType: {_cardType}, CreditLimit: {_creditLimit}");
        }
        public override void SetCreditLimit(int limit)
        {
            _creditLimit = limit;
        }
        public VisaCreditCard(int creditLimit)
        {
            _creditLimit = creditLimit;
            _cardType = "visa";
        }
    }

    public abstract class CardFactory
    {
        public abstract CreditCard GetCreditCard();

        // main logic
        public void GetCardInformation()
        {
            CreditCard c = GetCreditCard();
            c.GetCardInformation();
        }
    }

    public class MasterFactory : CardFactory
    {
        private int _creditLimit;

        public override CreditCard GetCreditCard()
        {
            return new MasterCreditCard(_creditLimit);
        }

        public MasterFactory(int creditLimit)
        {
            _creditLimit = creditLimit;
        }

    }

    public class VisaFactory : CardFactory
    {
        private int _creditLimit;
        public override CreditCard GetCreditCard()
        {
            return new VisaCreditCard(_creditLimit);
        }
        public VisaFactory(int creditLimit)
        {
            _creditLimit = creditLimit;
        }
    }

}


// 如果没有工厂方法，会发生什么？
// 主程序需要知道具体生成什么类型的对象，同时，还要再去用该类型的行为。

// 主程序不需要知道具体的实现细节，只是用factory生成一个基类对象，只管用该基类的行为。
// 当然了，要告诉factory去什么具体的什么继承类。

// 所以使用工厂方法的话必然有一个前提就是:
// 仅当这些产品具有共同的基类或者接口时，子类才能返回不同类型的产品，
// 同时基类中的工厂方法还应将其返回类型，声明为这一共有“接口”或者基类。