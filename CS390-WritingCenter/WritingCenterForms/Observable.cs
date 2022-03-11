using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingCenterForms
{
    public interface Observable
    {
        void add(Observer obs);
        void remove(Observer obs);
        void notifyObservers();
    }
}
