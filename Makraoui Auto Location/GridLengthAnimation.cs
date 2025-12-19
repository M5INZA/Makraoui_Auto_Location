using System;
using System.Windows;
using System.Windows.Media.Animation;

public class GridLengthAnimation : AnimationTimeline
{
    public DoubleAnimation DoubleAnimation { get; }

    public GridLengthAnimation(DoubleAnimation animation)
    {
        DoubleAnimation = animation;
    }

    public override Type TargetPropertyType => typeof(GridLength);

    protected override Freezable CreateInstanceCore()
        => new GridLengthAnimation(DoubleAnimation);

    public override object GetCurrentValue(
        object defaultOriginValue,
        object defaultDestinationValue,
        AnimationClock animationClock)
    {
        double value = DoubleAnimation.GetCurrentValue(
            ((GridLength)defaultOriginValue).Value,
            ((GridLength)defaultDestinationValue).Value,
            animationClock);

        return new GridLength(value);
    }
}
