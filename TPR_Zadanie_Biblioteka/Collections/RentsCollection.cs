﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace DL.Collections
{
    class RentsCollection : ICrudOperations<Rent>
    {
        private ObservableCollection<Rent> _rents;

        public void Add(Rent obj)
        {
            if (_rents.Where(rent => rent.Id.Equals(obj.Id)) != null)
            {
                throw new Exception("Rent with this ID already exists!");
            }
            _rents.Add(obj);
        }

        public void Delete(Rent obj)
        {
            _rents.Remove(obj);
        }

        public Rent Get(string id)
        {
            return (Rent)_rents.Where(rent => rent.Id.Equals(id));
        }

        public IEnumerable<Rent> GetAll()
        {
            return _rents;
        }

        public void Update(string id, Rent obj)
        {
            for (int i = 0; i < _rents.Count; i++)
            {
                if (_rents[i].Id.Equals(id))
                {
                    _rents[i] = obj;
                }
            }
        }
    }
}