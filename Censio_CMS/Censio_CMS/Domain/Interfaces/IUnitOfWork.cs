using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IOrganizationRepository Organization { get; }
        IGameMasterRepository GameMaster { get; }
        IAvatarRepository Avatar { get; }
        IBehaviorElementRepository BehaviorElement { get; }
        IGameRepository Game { get; }
        IGameChallengelevelRepository GameChallengelevel { get; }
        IGameAttemptdataRepository GameAttemptdata { get; }
        IGame1PuzzleImgRepository Game1PuzzleImg { get; }
        ISubliminalMeasurement1Repository SubliminalMeasurement1 { get; }
        ISubliminalMeasurement2Repository SubliminalMeasurement2 { get; }
        IGuideDialoguesRepository GuideDialogues { get; }
        IGame5AttemptdataRepository Game5Attemptdata { get; }
        IGame3FestivalsRepository Game3Festvals { get; }
        IGame3FestivalResetRepository Game3FestvalReset { get; }
        IGame3InstructionsRepository Game3Instructions { get; }
        IGame3LevelsRepository Game3Levels { get; }
        IQuestionsRepository Questions { get; }
        IGame4LevelInstructionsRepository Game4LevelInstructions { get; }
        IGame4LevelMasterRepository Game4LevelMaster { get; }
        IGame4WordMasterRepository Game4WordMaster { get; }
        IGame4LevelImagesRepository Game4LevelImages { get; }

        int Complete();
    }
}
