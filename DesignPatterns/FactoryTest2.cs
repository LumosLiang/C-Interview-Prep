using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    // client logic or business logic
    // 我知道要完成某一个逻辑要调一个类，但是我想虚拟化到一定程度，就是：
    // 我不想关心这个类的具体实现是什么，我只想用他的基类来完成所有事情，我只给你一个。
    // 所以给我一个工厂方法，成批量的创建，我告诉你什么类型，你来返回这个类对应的基类对象

    // 不变的是客户端逻辑.
    public enum ProductType
    {
        productOne = 1,
        productTwo = 2,
    }

    class FactoryTest2
    {
        FactoryCreator fc;

        public void Go(ProductType creatorType)
        {
            switch (creatorType)
            {
                case ProductType.productOne:
                    fc = new FactoryCreator1();
                    break;
                case ProductType.productTwo:
                    fc = new FactoryCreator2();
                    break;
                default:
                    fc = new FactoryCreator1();
                    break;
            }

            fc.DoSth();

            //IProduct p = fc.CreateProduct();
            //p.Operation()

            // 如果不这样
            //ConcreteProduct1 cp1 = new ConcreteProduct1();
            //cp1.Operation();
            //ConcreteProduct2 cp2 = new ConcreteProduct2();
            //cp1.Operation();

            //IProduct op2 = new ConcreteProduct1();
            //op2.Operation();

        }
    }


    public abstract class FactoryCreator
    {
        public abstract IProduct CreateProduct();

        public virtual void DoSth()
        {
            IProduct product = CreateProduct();
            product.Operation();
        }
    }

    public class FactoryCreator1 : FactoryCreator
    {
        public override IProduct CreateProduct()
        {
            return new ConcreteProduct1();
        }
        public override void DoSth() 
        {
            //...different logic
        }

    }

    public class FactoryCreator2 : FactoryCreator
    {
        public override IProduct CreateProduct()
        {
            return new ConcreteProduct2();
        }
        public override void DoSth()
        {
            //...
        }
    }


    public interface IProduct 
    {
        string Operation();
    }

    public class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct1}";
        }
    }

    public class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct2}";
        }
    }



}
