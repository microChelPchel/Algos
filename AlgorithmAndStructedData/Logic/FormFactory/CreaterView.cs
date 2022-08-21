using AlgorithmAndStructedData.Views;
using System.Windows.Forms;

namespace AlgorithmAndStructedData.Logic.FormFactory
{
    public class CreaterView : ICreaterView
    {
        public Control CallView(ViewEnum viewType)
        {
            Control view = null;

            switch (viewType)
            {
                case ViewEnum.Alghos:
                    view = new AlgosForm();
                    break;
                case ViewEnum.Structs:
                    view = new StructForm();
                    break;
                case ViewEnum.Settings:
                    view = new SettingsForm();
                    break;
                case ViewEnum.Patterns:
                    view = new PatternForm();
                    break;
                case ViewEnum.BubbleSort:
                    view = new Panel();
                    break;
            }

            return view;
        }
    }
}
