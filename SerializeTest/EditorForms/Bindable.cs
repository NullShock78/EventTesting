using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorForms
{
    class Bindable<T>
    {
        T value;
        List<BindableTarg<T>> Targs = new List<BindableTarg<T>>();

        public Bindable(T def = default(T))
        {
            value = def;
        }

        public void Bind(BindableTarg<T> target)
        {
            Targs.Add(target);
        }

        public void Update(BindableTarg<T> calling, T val)
        {
            for (int j = 0; j < Targs.Count; j++)
            {
                if (!object.ReferenceEquals(Targs[j], calling))
                {
                    Targs[j].Update(val);
                }
            }
        }

        public static implicit operator T(Bindable<T> b)
        {
            return b.value;
        }
    }

    class BindableTarg<T>
    {
        Bindable<T> bindable = null;
        Action<T> updateAction;
        public BindableTarg(Action<T> updateAction, Bindable<T> bindable)
        {
            this.updateAction = updateAction;
            Bind(bindable);
        }

        public void Bind(Bindable<T> b)
        {
            bindable = b;
        }

        public void SetVal(T val)
        {
            bindable.Update(this, val);
        }

        public void Update(T val)
        {
            this.updateAction(val);
        }

        public static implicit operator T(BindableTarg<T> b)
        {
            return b.bindable;
        }
    }


    class A
    {
        public A()
        {
            int l = 0;
            int m = 0;
            Bindable<int> b = new Bindable<int>();
            BindableTarg<int> targ = new BindableTarg<int>((x) => { l = x; }, b);
            BindableTarg<int> targ2 = new BindableTarg<int>((x) => { m = x; }, b);




        }

    }

}
