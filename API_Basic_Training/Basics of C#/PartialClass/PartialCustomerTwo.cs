namespace PartialClass
{
    public partial class PartialCustomer
    {
        #region Public Methods
        public string GetFullName()
        {
            return _firstName + " " + _lastName;
        }
        #endregion
    }
}
