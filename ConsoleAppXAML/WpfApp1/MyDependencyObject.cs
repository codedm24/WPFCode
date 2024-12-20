﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    //internal class MyDependencyObject : DependencyObject
    internal class MyDependencyObject : UIElement
    {
        public int Value
        {
            get { return (int)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register("Value",
            typeof(int),
            typeof(MyDependencyObject),
            new PropertyMetadata(0, OnValueChanged, CoerceValue));

        public int Minimum
        {
            get { return (int)GetValue(MinimumProperty); }
            set { SetValue(MinimumProperty, value); }
        }

        public static readonly DependencyProperty MinimumProperty = DependencyProperty.Register(nameof(Minimum),
            typeof(int),
            typeof(MyDependencyObject),
            new PropertyMetadata(0));

        public int Maximum
        {
            get { return (int)GetValue(MaximumProperty); }
            set { SetValue(MaximumProperty, value); }
        }

        public static readonly DependencyProperty MaximumProperty = DependencyProperty.Register(nameof(Maximum),
            typeof(int),
            typeof(MyDependencyObject),
            new PropertyMetadata(0));

        // used with DependencyObject inheritance
        //private static void OnValueChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        //{ 
        //    int oldValue = (int)e.OldValue;
        //    int newValue = (int)e.NewValue;
        //}

        public static object CoerceValue(DependencyObject d, object baseValue)
        {
            int newValue = (int)baseValue;
            MyDependencyObject control = (MyDependencyObject)d;
            newValue = Math.Max(control.Minimum, Math.Min(newValue, control.Maximum));
            return newValue;
        }

        private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            MyDependencyObject control = (MyDependencyObject)d;
            var e1 = new RoutedPropertyChangedEventArgs<int>((int)e.OldValue,(int)e.NewValue, ValueChangedEvent);
            control.OnValueChanged(e1);
        }

        public static readonly RoutedEvent ValueChangedEvent = EventManager.RegisterRoutedEvent(nameof(ValueChanged), RoutingStrategy.Bubble,
            typeof(RoutedPropertyChangedEventHandler<int>), typeof(MyDependencyObject));

        public event RoutedPropertyChangedEventHandler<int> ValueChanged
        {
            add
            {
                AddHandler(ValueChangedEvent, value);
            }
            remove 
            {
                RemoveHandler(ValueChangedEvent, value); 
            }
        }

        protected virtual void OnValueChanged(RoutedPropertyChangedEventArgs<int> args) {
            RaiseEvent(args);
        }

    }
}
