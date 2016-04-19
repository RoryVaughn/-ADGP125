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
    
public class Combat
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

        public Combat()
        {
            
            _fsm = new FSM<COMBATSTATES>();
           GenerateFSM();
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
        public void startFSM()
        {
            _fsm.Transition(_fsm.state, COMBATSTATES.Attack);
            
        }
        public void gameover()
        {
            _fsm.Transition(_fsm.state, COMBATSTATES.GameOver);

        }
        public void win()
        {
            _fsm.Transition(_fsm.state, COMBATSTATES.YouWin);
        }

    }
}
