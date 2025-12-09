namespace GruppXproject
{
    public class Booking
    {
        public DateTime PlanedTime { get; set; }
        public Costumers Costumer { get; set; }
        public Services Service { get; set; }

        public Booking(DateTime PlanedTime, Services Service, Costumers Costumer)
        {
            PlanedTime = planedTime;
            Service = service;
            Costumer = costumer;
        }

        public override string ToString()
        {
            return
                "*** Bokning Bekräftad! ***\n" +
                $"Tid: {PlanedTime: yyyy/MM/dd/hh}" +
                $"Tjänst: {Service}" +
                $"Reg.Nr {Costumer}";
        }
    }
}