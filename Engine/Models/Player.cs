using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Engine.Models
{
    public class Player : INotifyPropertyChanged {
        private String _name;
        private String _characterClass;
        private int _hitPoints;
        private int _experienceLevel;
        private int _level;
        private int _gold;

        public String Name {
            get { return _name; }
            set {
                _name = value;
                OnPropertyChanged("Name");
            } 
        }
        public String CharacterClass { 
            get { return _characterClass; } 
            set {
                _characterClass = value;
                OnPropertyChanged("CharacterClass");
            }
        }
        public int HitPoints { 
            get { return _hitPoints; }
            set
            {
                _hitPoints = value;
                OnPropertyChanged("HitPoints");
            }
        }
        public int ExperienceLevel
        {
            get { return _experienceLevel; }
            set 
            { 
                _experienceLevel = value;
                OnPropertyChanged("ExperienceLevel");
            }
        }
        public int Level {
            get { return _level; }
            set
            {
                _level = value;
                OnPropertyChanged("Level");
            } 
        }
        public int Gold {
            get { return _gold; }
            set {
                _gold = value;
                OnPropertyChanged("Gold");
            } 
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
