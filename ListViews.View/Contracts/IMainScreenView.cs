using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViews.View.Contracts
{
    public interface IMainScreenView
    {
        event Action OnNewListCreated;
        event Action OnLoadedFile;

        void Hide();
    }
}
