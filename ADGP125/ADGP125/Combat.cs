using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADGP125
{
    
    public sealed class Single
    {
        
    }
    
class Combat
    {
       

    enum COMBATSTATES
        {
            init,
            Attack,
            GameOver,
            YouWin,
            
            count
        }

        FSM<COMBATSTATES> _fsm;

        Combat()
        {
            _fsm = new FSM<COMBATSTATES>();
        }

        void GenerateFSM()
        {
            foreach (int i in Enum.GetValues(typeof(COMBATSTATES)))
            {
                if ((COMBATSTATES)i != COMBATSTATES.count)
                {
                    _fsm.AddState((COMBATSTATES)i);
                }
            }

            _fsm.AddTransition(COMBATSTATES.init, COMBATSTATES.Attack);
            _fsm.AddTransition(COMBATSTATES.Attack, COMBATSTATES.GameOver);
            _fsm.AddTransition(COMBATSTATES.Attack, COMBATSTATES.YouWin);
        }
        
    }
}
