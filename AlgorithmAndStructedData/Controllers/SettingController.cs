using AlgorithmAndStructedData.Models.Base;

namespace AlgorithmAndStructedData.Controllers
{
    internal class SettingController : BaseController
    {

        public SettingController() { }

        public void SaveSettings(Section section, Statistic statistic)
        {
            Save(section, "section.dat");
            Save(statistic, "statistic.dat");
        }

        public (Section, Statistic) LoadSettings()
        {
            var section = Load<Section>("section.dat") ?? new Section();
            var statistic = Load<Statistic>("statistic.dat") ?? new Statistic();
            return (section,statistic);
        }



    }
}
