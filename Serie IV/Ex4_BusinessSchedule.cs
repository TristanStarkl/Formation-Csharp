using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_IV
{
    public class BusinessSchedule
    {
        private SortedDictionary<DateTime, TimeSpan> _PoolOfMeetings;
        private DateTime _BeginRange;
        private DateTime _EndRange;
        public const string _FormatTime = "dd/MM/yyyy HH:mm:ss";


        public BusinessSchedule()
        {
            this._PoolOfMeetings = new SortedDictionary<DateTime, TimeSpan>();
            this._BeginRange = new DateTime(2020, 1, 1);
            this._EndRange = new DateTime(2030, 1, 1);
        }

        public bool IsEmpty()
        {
            return this._PoolOfMeetings.Count == 0;
        }

        public void SetRangeOfDates(DateTime begin, DateTime end)
        {
            if (end <= begin)
                throw new Exception("Erreur: la date de fin est inférieure à la date de début");
            if (!this.IsEmpty())
                throw new Exception("Ereur: on ne peut modifier la période que si la pool est vide.");
            this._BeginRange = begin;
            this._EndRange = end;
        }

        private KeyValuePair<DateTime, DateTime> ClosestElements(DateTime beginMeeting)
        {
            TimeSpan closestReunionTimeSpan = TimeSpan.MaxValue;
            DateTime closestReunion = DateTime.MaxValue;
            DateTime closestReunion2 = DateTime.MaxValue;
            TimeSpan tmp;
            foreach (KeyValuePair<DateTime, TimeSpan> kvp in this._PoolOfMeetings)
            {
                tmp = beginMeeting - kvp.Key;
                if (tmp < closestReunionTimeSpan && tmp <= TimeSpan.Zero)
                {
                    closestReunionTimeSpan = tmp;
                    closestReunion = kvp.Key;
                }
                tmp = beginMeeting - kvp.Key;
                if (tmp < closestReunionTimeSpan && tmp > TimeSpan.Zero)
                {
                    closestReunionTimeSpan = tmp;
                    closestReunion2 = kvp.Key;
                }
            }

            return new KeyValuePair<DateTime, DateTime>(closestReunion, closestReunion2);
        }

        public bool AddBusinessMeeting(DateTime date, TimeSpan duration)
        {
            KeyValuePair<DateTime, DateTime> kvp; ;

            // On vérifie qu'on est bien dans les range;
            if (date < this._BeginRange || date > this._EndRange)
            {
                Console.WriteLine(date.ToString(BusinessSchedule._FormatTime) + " est en dehors de la range");
                return false;

            }
            if (this.IsEmpty())
            {
                this._PoolOfMeetings.Add(date, duration);
                return true;
            }
            kvp = this.ClosestElements(date);
            // Si la première réunion a un overlap on return false;
            try
            {
                if (kvp.Key + this._PoolOfMeetings[kvp.Key] < date)
                    return false;

                // Si la deuxième réunionjuste après a un overlap on return false
                if (date + duration > kvp.Value)
                    return false;

                this._PoolOfMeetings.Add(date, duration);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool DeleteBusinessMeeting(DateTime date, TimeSpan duration)
        {
            try
            {
                this._PoolOfMeetings.Remove(date);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int ClearMeetingPeriod(DateTime begin, DateTime end)
        {
            int nbRemoved = 0;
            foreach (KeyValuePair<DateTime, TimeSpan> kvp in this._PoolOfMeetings)
            {
                if ((kvp.Key > begin && kvp.Key < end) ||
                    (kvp.Key + kvp.Value > begin && kvp.Key + kvp.Value < end))
                {
                    this._PoolOfMeetings.Remove(kvp.Key);
                    nbRemoved++;
                }
            }
            return nbRemoved;
        }

        public void DisplayMeetings()
        {
            string beginDate = this._BeginRange.ToString(BusinessSchedule._FormatTime);
            string endDate = this._BeginRange.ToString(BusinessSchedule._FormatTime);
            DateTime endMeeting;
            int nbMeetings = 1;

            Console.WriteLine($"Emploi du temps : {beginDate} - {endDate}");
            Console.WriteLine("----------------------------------------------");
            if (this.IsEmpty())
                Console.WriteLine("Pas de réunions programmées");
            else
            {
                foreach (KeyValuePair<DateTime, TimeSpan> kvp in this._PoolOfMeetings)
                {
                    endMeeting = kvp.Key + kvp.Value;
                    beginDate = kvp.Key.ToString(BusinessSchedule._FormatTime);
                    endDate = endMeeting.ToString(BusinessSchedule._FormatTime);
                    Console.WriteLine($"Réunion {nbMeetings.ToString().PadLeft(3)}       : {beginDate} - {endDate}");
                    nbMeetings++;
                }
            }
            Console.WriteLine("----------------------------------------------");
        }
    }
}
