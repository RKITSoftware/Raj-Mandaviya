namespace PartialClass
{
    public partial class PartialCustomer
    {
        #region Private Members
        private string _firstName;
        private string _lastName;
        #endregion

        #region Public Properties
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        #endregion
    }
}
