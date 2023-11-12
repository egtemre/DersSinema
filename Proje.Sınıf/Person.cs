namespace Proje.Sinif
{
    public class Person
    {
        public Person()
        {

        }

        private string name;
        public string Name
        {

            get
            {
                return name;

            }
            set
            {

                if (value.Length < 30)
                    name = value;
                else
                    name = "tekrar deneyiniz";
            }
        }
    }

}