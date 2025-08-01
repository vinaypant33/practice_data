using System;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Controls.Custom_Controls
{
    internal class Analog_Clock : Control
    {
        private Line hourhand;
        private Line minutehand;
        private Line second_hand;
        private DispatcherTimer timer;

        static Analog_Clock()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(Analog_Clock),
                new System.Windows.FrameworkPropertyMetadata(typeof(Analog_Clock))
            );
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            hourhand = GetTemplateChild("hour_hand") as Line;
            minutehand = GetTemplateChild("minute_hand") as Line;
            second_hand = GetTemplateChild("second_hand") as Line;

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += (s, e) => UpdateHands();
            timer.Start();
        }

        private void UpdateHands()
        {
            DateTime now = DateTime.Now;

            if (hourhand != null)
                hourhand.RenderTransform = new RotateTransform((now.Hour % 12 / 12.0) * 360 + (now.Minute / 60.0) * 30, 0.5, 0.5);

            if (minutehand != null)
                minutehand.RenderTransform = new RotateTransform((now.Minute / 60.0) * 360, 0.5, 0.5);

            if (second_hand != null)
                second_hand.RenderTransform = new RotateTransform((now.Second / 60.0) * 360, 0.5, 0.5);
        }
    }
}
