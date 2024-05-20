
namespace Lab5_dot_net
{
    public class Prescription : IPrescription
    {
        private readonly string _doctor;
        private DateTime _expirationDate;

        public Prescription(string doctor, DateTime expirationDate)
        {
            _doctor = doctor;
            _expirationDate = expirationDate;
        }
        public string GetDescription()
        {
            return $"Рецепт вiд лiкаря {_doctor}";
        }

        public DateTime GetExpirationDate()
        {
            return _expirationDate;
        }
    }
}
