using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingCenterForms
{
    public interface Observer
    {
        void addObservable(Observable observable);
        void update(int time, int day);
    }
}
