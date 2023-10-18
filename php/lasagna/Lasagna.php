<?php

declare(strict_types=1);

class Lasagna
{
    function expectedCookTime()
    {
        return 40;
    }

    function remainingCookTime($elapsed_minutes)
    {
        return $this->expectedCookTime() - $elapsed_minutes;
    }

    function totalPreparationTime(int $layers_to_prep)
    {
        return $layers_to_prep * 2;
    }

    function totalElapsedTime($layers_to_prep, $elapsed_minutes)
    {
        return $this->totalPreparationTime($layers_to_prep) + $elapsed_minutes;
    }

    function alarm()
    {
        return "Ding!";
    }
}
