using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_dot_net
{
    public class DoctorPatronymicDecorator : PrescriptionDecorator
    {
        private readonly string _doctorPatronymic;

        public DoctorPatronymicDecorator(IPrescription prescription, string doctorPatronymic) : base(prescription)
        {
            _doctorPatronymic = doctorPatronymic;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " " + _doctorPatronymic;
        }
    }
}
