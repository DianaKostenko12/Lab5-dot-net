
namespace Lab5_dot_net
{
    public abstract class PrescriptionDecorator : IPrescription
    {
        protected IPrescription _prescription;
        public PrescriptionDecorator(IPrescription prescription)
        {
            _prescription = prescription;
        }
        public virtual string GetDescription()
        {
           return _prescription.GetDescription();
        }

        public virtual DateTime GetExpirationDate()
        {
            return _prescription.GetExpirationDate();
        }
    }
}
