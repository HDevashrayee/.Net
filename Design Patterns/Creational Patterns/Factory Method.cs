using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational_Patterns.Factory_Method
{
    public class Factory_Method
    {
        /*The Factory Method design pattern defines an interface for creating an object, 
         * but let subclasses decide which class to instantiate. 
         * This pattern lets a class defer instantiation to subclasses.*/

        //Frequency of use: high

        /*
         Participants#
            The classes and objects participating in this pattern include:

        Product  (Page)
            defines the interface of objects the factory method creates

        ConcreteProduct  (SkillsPage, EducationPage, ExperiencePage)
            implements the Product interface

        Creator  (Document)
            declares the factory method, which returns an object of type Product. 
            Creator may also define a default implementation of the factory method that returns a default ConcreteProduct object.
            may call the factory method to create a Product object.

        ConcreteCreator  (Report, Resume)
            overrides the factory method to return an instance of a ConcreteProduct.
         */
    }
}

namespace Design_Patterns.Creational_Patterns.FactoryMethod.Structural
{
    /*
     This structural code demonstrates the Factory method offering great flexibility in creating different objects. 
     The Abstract class may provide a default object, but each subclass can instantiate an extended version of the object.
     */


    /// <summary>
    /// The 'Product' abstract class
    /// </summary>
    public abstract class Product
    {
        public abstract void ProductWrite();
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class ConcreteProductA:Product
    {
        public override void ProductWrite()
        {
            Console.WriteLine("ConcreteProductA");
        }
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class ConcreteProductB:Product
    {
        public override void ProductWrite()
        {
            Console.WriteLine("ConcreteProductB");
        }
    }

    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
    public abstract class Creator
    {
        public abstract Product FactoryMethod();
    }

    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }

    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public class ConcreteCreatorB: Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductB();   
        }
    }
}

namespace Design_Patterns.Creational_Patterns.FactoryMethod.RealWorld
{
    /*
     This real-world code demonstrates the Factory method offering flexibility in creating different documents. 
    The derived Document classes Report and Resume instantiate extended versions of the Document class. 
    Here, the Factory Method is called in the constructor of the Document base class.
     */

    /// <summary>
    /// The 'Product' abstract class
    /// </summary>
    /// 

    public abstract class Page
    {
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    /// 

    public class SkillPage : Page
    {
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    /// 

    public class EducationPage:Page
    {
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class ExperiencePage : Page
    {
    }
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class IntroductionPage : Page
    {
    }
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class ResultsPage : Page
    {
    }
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class ConclusionPage : Page
    {
    }
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class SummaryPage : Page
    {
    }
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class BibliographyPage : Page
    {
    }
    
    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>

    public abstract class Document
    {
        private List<Page> _pages = new List<Page>();

        // Constructor calls abstract Factory method
        public Document()
        {
            this.CreatePages();
        }

        public List<Page> Pages 
        { 
            get { return _pages; } 
        }

        //Factory Method

        public abstract void CreatePages();
    }

    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    /// 

    public class Resume: Document
    {
        public override void CreatePages()
        {
            Pages.Add(new SkillPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }

    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    /// 

    public class Report : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }
}