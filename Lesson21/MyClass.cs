namespace Lesson21
{
    internal class MyClass
    {
        public string Name { get; set; }
        private string SurName { get; set; }
        internal string Car { get; set; }
        protected string Food { get; set; }
        protected internal string FoodName { get; set; }
        private protected string CarName { get; set; }

    }


    internal class MyClass1 : MyClass
    {
        internal MyClass1()
        {
            FoodName = string.Empty;
            Food = string.Empty;
            CarName = string.Empty;

        }
    }
}
