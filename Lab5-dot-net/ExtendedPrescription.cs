
namespace Lab5_dot_net
{
    public class ExtendedPrescription : PrescriptionDecorator
    {
        private int _extraDays;

        public ExtendedPrescription(IPrescription prescription, int extraDays) : base(prescription)
        {
            _extraDays = extraDays;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + $", продовжено на {_extraDays} днiв";
        }

        public override DateTime GetExpirationDate()
        {
            return base.GetExpirationDate().AddDays(_extraDays);
        }
    }
}
