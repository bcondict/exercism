using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        double successRate = 0.0;

        if (speed >= 1)
            successRate = 1.0;
        if (speed >= 5)
            successRate = 0.9;
        if (speed == 9)
            successRate = 0.8;
        if (speed >= 10)
            successRate = 0.77;

        return successRate;
    }
    
    public static double ProductionRatePerHour(int speed) => 221 * speed * SuccessRate(speed);

    public static int WorkingItemsPerMinute(int speed) => (int)ProductionRatePerHour(speed) / 60;
}
