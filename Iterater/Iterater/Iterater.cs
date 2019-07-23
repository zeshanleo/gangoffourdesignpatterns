using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterater
{
    public abstract class Aggregate
    {
        public abstract Iterater CreateIterater();
    }

    public class ConcreteAggregate : Aggregate
    {
        private ArrayList items = new ArrayList();

        // Inserts or retrieve objects from the aggregate
        public object this[int index]
        {
            set
            {
                items.Insert(index, value);
            }
            get
            {
                return items[index];
            }
        }

        public override Iterater CreateIterater()
        {
            return new ConcreteIterater(this);
        }

        public int Count
        {
            get
            {
                return items.Count;
            }
        }
    }

    public abstract class Iterater
    {
        public abstract object First();
        public abstract object Current();
        public abstract object Next();
        public abstract bool IsDone();
    }

    public class ConcreteIterater : Iterater
    {
        private ConcreteAggregate _aggregate;
        private int current = 0;

        public ConcreteIterater(ConcreteAggregate aggregate)
        {
            this._aggregate = aggregate;
        }

        public override object Current()
        {
            return _aggregate[current];
        }

        public override object First()
        {
            return _aggregate[0];
        }

        public override bool IsDone()
        {
            return (current >= _aggregate.Count);
        }

        public override object Next()
        {
            object ret = null;
            if (current < _aggregate.Count - 1)
            {
                ret = _aggregate[++current];
            }

            return ret;
        }
    }
}
