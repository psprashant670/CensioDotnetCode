

using DataAccess.Data;
using DataAccess.EFCore.Repositories;
using Domain.Interfaces;
using System;


namespace DataAccess.EFCore.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly db_censio_betaContext _context;
        public UnitOfWork(db_censio_betaContext context)
        {
            _context = context;
            Organization = new OrganizationRepository(_context);
            GameMaster = new GameMasterRepository(_context);
            Avatar = new AvatarRepository(_context);
            BehaviorElement = new BehaviorElementRepository(_context);
            Game = new GameRepository(_context);
            GameChallengelevel = new GameChallengelevelRepository(_context);
            GameAttemptdata = new GameAttemptdataRepository(_context);
            Game1PuzzleImg = new Game1PuzzleImgRepository(_context);
            SubliminalMeasurement1 = new SubliminalMeasurement1Repository(_context);
            SubliminalMeasurement2 = new SubliminalMeasurement2Repository(_context);
            GuideDialogues = new GuideDialoguesRepository(_context);
            Game5Attemptdata = new Game5AttemptdataRepository(_context);
            Game3Festvals = new Game3FestivalsRepository(_context);
            Game3FestvalReset = new Game3FestivalResetRepository(_context);
            Game3Instructions = new Game3InstructionsRepository(_context);
            Game3Levels = new Game3LevelsRepository(_context);
            Questions = new QuestionsRepository(_context);
            Game4LevelInstructions = new Game4LevelInstructionsRepository(_context);
            Game4LevelMaster = new Game4LevelMasterRepository(_context);
            Game4WordMaster = new Game4WordMasterRepository(_context);
            Game4LevelImages = new Game4LevelImagesRepository(_context);

        }
        public IOrganizationRepository Organization { get; private set; }
        public IGameMasterRepository GameMaster { get; private set; }
        public IAvatarRepository Avatar { get; private set; }
        public IBehaviorElementRepository BehaviorElement { get; private set; }
        public IGameRepository Game { get; private set; }
        public IGameChallengelevelRepository GameChallengelevel { get; private set; }
        public IGameAttemptdataRepository GameAttemptdata { get; private set; }
        public IGame1PuzzleImgRepository Game1PuzzleImg { get; private set; }
        public ISubliminalMeasurement1Repository SubliminalMeasurement1 { get; private set; }
        public ISubliminalMeasurement2Repository SubliminalMeasurement2 { get; private set; }
        public IGuideDialoguesRepository GuideDialogues { get; private set; }
        public IGame5AttemptdataRepository Game5Attemptdata { get; private set; }
        public IGame3FestivalsRepository Game3Festvals { get; private set; }
        public IGame3FestivalResetRepository Game3FestvalReset { get; private set; }
        public IGame3InstructionsRepository Game3Instructions { get; private set; }
        public IGame3LevelsRepository Game3Levels{ get; private set; }
        public IQuestionsRepository Questions { get; private set; }
        public IGame4LevelInstructionsRepository Game4LevelInstructions { get; private set; }
        public IGame4LevelMasterRepository Game4LevelMaster { get; private set; }
        public IGame4WordMasterRepository Game4WordMaster { get; private set; }
        public IGame4LevelImagesRepository Game4LevelImages{ get; private set; }


        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
