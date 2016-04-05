using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADGP125
{
    class Combat
    {
        enum COMBATSTATES
        {
            init,
            ActionSelect,
            Attack,
            Check,
            EnemyAtt,
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

            _fsm.AddTransition(COMBATSTATES.init, COMBATSTATES.ActionSelect);
            _fsm.AddTransition(COMBATSTATES.ActionSelect, COMBATSTATES.Attack);
            _fsm.AddTransition(COMBATSTATES.Attack, COMBATSTATES.Check);
            _fsm.AddTransition(COMBATSTATES.Check, COMBATSTATES.EnemyAtt);
            _fsm.AddTransition(COMBATSTATES.EnemyAtt, COMBATSTATES.Check);
            _fsm.AddTransition(COMBATSTATES.Check, COMBATSTATES.Attack);
           
        }
    }
}
