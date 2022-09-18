using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfGraphControl {
    public class NodeControl : Control {
        public object Node {
            get { return GetValue(NodeProperty); }
            set { SetValue(NodeProperty, value); }
        }

        public static readonly DependencyProperty NodeProperty =
            DependencyProperty.Register("Node", typeof(object), typeof(NodeControl), new UIPropertyMetadata(null));
    }
}
