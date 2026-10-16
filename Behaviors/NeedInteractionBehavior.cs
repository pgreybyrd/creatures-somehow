using Desktop_Creatures.Needs;
using Desktop_Creatures.Utilities;
using Desktop_Creatures.World;
using Point = System.Windows.Point;

namespace Desktop_Creatures.Behaviors;

internal class NeedInteractionBehavior : IBehavior
{
    private readonly NeedManager _needs;
    private readonly NeedType _needType;

    private readonly PointOfInterestManager _poiManager;
    private readonly PointOfInterestType _poiType;
    private readonly WorldInteractionPointType _interactionType;

    private readonly Func<Point> _getPosition;
    private readonly Func<bool> _canSearch;
    private readonly Func<WorldInteractionTarget, bool> _trySetTarget;

    private readonly double _searchCooldownSeconds;

    private double _cooldownSeconds;

    public NeedInteractionBehavior(
        NeedManager needs,
        NeedType needType,
        PointOfInterestManager poiManager,
        PointOfInterestType poiType,
        WorldInteractionPointType interactionType,
        Func<Point> getPosition,
        Func<bool> canSearch,
        Func<WorldInteractionTarget, bool> trySetTarget,
        double searchCooldownSeconds)
    {
        _needs = needs;
        _needType = needType;

        _poiManager = poiManager;
        _poiType = poiType;
        _interactionType = interactionType;

        _getPosition = getPosition;
        _canSearch = canSearch;
        _trySetTarget = trySetTarget;

        _searchCooldownSeconds =
            searchCooldownSeconds;
    }

    public void Update(
        double deltaSeconds)
    {
        if (_cooldownSeconds > 0)
        {
            _cooldownSeconds =
                Math.Max(
                    0,
                    _cooldownSeconds -
                    deltaSeconds);
        }

        bool isActive =
            _needs.IsActive(
                _needType);

        bool canSearch =
            _canSearch();

        Logger.LogDebug(
            DebugCategory.Behavior,
            $"NeedInteractionBehavior: " +
            $"need={_needType}, " +
            $"active={isActive}, " +
            $"value={_needs.GetNeed(_needType)}, " +
            $"canSearch={canSearch}, " +
            $"cooldown={_cooldownSeconds:F1}");

        if (!isActive)
            return;

        if (!canSearch ||
            _cooldownSeconds > 0)
        {
            return;
        }

        var target =
            _poiManager.FindNearestWorldInteractionPoint(
                _getPosition(),
                _interactionType,
                _poiType);

        Logger.LogDebug(
            DebugCategory.Behavior,
            target is null
                ? $"No {_interactionType} interaction target found."
                : $"{_interactionType} target found at " +
                  $"({target.Position.X:F1}, {target.Position.Y:F1})");

        if (target is null)
        {
            StartCooldown();
            return;
        }

        bool accepted =
            _trySetTarget(
                target);

        Logger.LogDebug(
            DebugCategory.Behavior,
            accepted
                ? $"{_interactionType} target accepted by creature."
                : $"{_interactionType} target rejected by creature.");

        if (!accepted)
            StartCooldown();
    }

    private void StartCooldown()
    {
        _cooldownSeconds =
            _searchCooldownSeconds;
    }
}