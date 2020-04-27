using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sophis.utils;

namespace sophis.scenario
{
    public class CSMScenario : IDisposable
    {
        private static SortedList<string, CSMScenario> _scenarios = new SortedList<string, CSMScenario>();

        public static void Register(string key, CSMScenario prototype)
        {
            _scenarios.Add(key, prototype);
        }

        public virtual eMProcessingType GetProcessingType()
        {
            return eMProcessingType.M_pUserPreference;
        }

        public unsafe static SortedList<string, CSMScenario> GetAllPrototypes()
        {
            return _scenarios;
        }

        public unsafe static List<string> GetPrototypeKeys()
        {
            return _scenarios.Keys.ToList();
        }

        public static int GetNbPrototypes()
        {
            return _scenarios.Count;
        }

        public virtual bool AvailableForScenarioList()
        {
            return false;
        }

        public virtual bool InTheAnalysisMenu()
        {
            return false;
        }

        public virtual bool AvailableForReport()
        {
            return false;
        }

        public virtual bool AlwaysEnabled()
        {
            return false;
        }

        public virtual CMString GetName()
        {
            throw new NotImplementedException();
        }

        public virtual void Run()
        {
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
