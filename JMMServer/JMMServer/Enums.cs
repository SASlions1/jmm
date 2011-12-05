﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JMMServer
{
	public enum CommandRequestType
	{
		ProcessFile = 1,
		AniDB_GetAnimeHTTP = 2,
		AniDB_GetAnimeUDP = 3,
		AniDB_GetFileUDP = 4,
		AniDB_AddFileUDP = 5,
		AniDB_UpdateWatchedUDP = 6,
		TvDBSearch = 7,
		AniDB_GetCharsCreators = 8,
		AniDB_GetCharacter = 9,
		AniDB_GetCreator = 10,
		HashFile = 11,
		WebCache_SendFileHash = 12,
		WebCache_SendAniDBFile = 13,
		WebCache_SendXRefFileEpisode = 14,
		WebCache_DeleteXRefFileEpisode = 15,
		WebCache_DeleteXRefTvDB = 16,
		WebCache_DeleteXRefAniDBTvDB = 17,
		WebCache_SendXRefAniDBTvDB = 18,
		AniDB_GetReviews = 20,
		AniDB_GetReleaseGroupStatus = 21,
		AniDB_GetUpdated = 22,
		AniDB_SyncMyList = 23,
		AniDB_GetReleaseGroup = 24,
		AniDB_GetCalendar = 25,
		AniDB_GetTitles = 26,
		AniDB_SyncVotes = 27,
		AniDB_VoteAnime = 28,
		AniDB_VoteEpisode = 29,
		TvDB_SeriesEpisodes = 30,
		TvDB_DownloadImages = 31,
		TvDB_SearchAnime = 32,
		ImageDownload = 33,
		AniDB_DeleteFileUDP = 34,
		WebCache_SendXRefAniDBOther = 35,
		WebCache_DeleteXRefAniDBOther = 36,
		MovieDB_SearchAnime = 37,
		Trakt_SearchAnime = 38,
		WebCache_SendXRefAniDBTrakt = 39,
		WebCache_DeleteXRefAniDBTrakt = 40,
		Trakt_UpdateInfoImages = 41,
		Trakt_ShowScrobble = 42,
		Trakt_SyncCollection = 43,
		Trakt_SyncCollectionSeries = 44,
		Trakt_ShowEpisodeUnseen = 45,
		Trakt_UpdateAllSeries = 46
	}

	public enum CommandRequestPriority
	{
		Priority1 = 1,
		Priority2 = 2,
		Priority3 = 3,
		Priority4 = 4,
		Priority5 = 5,
		Priority6 = 6,
		Priority7 = 7,
		Priority8 = 8,
		Priority9 = 9,
		Priority10 = 10,
		Default = 99
	}

	public enum HashSource
	{
		DirectHash = 1, // the file was hashed by the user
		WebCacheFileName = 2 // the hash was retrieved from the web cache based on file name
	}

	public enum CrossRefSource
	{
		AniDB = 1,
		User = 2,
		WebCache = 3
	}

	public enum RenamingType
	{
		Raw = 1,
		MetaData = 2
	}

	public enum enFanartSize
	{
		All = 1,
		HD = 2,
		FullHD = 3
	}

	public enum RenamingLanguage
	{
		Romaji = 1,
		English = 2
	}

	public enum Storage
	{
		Unknown = 1,
		HDD = 2,
		CD = 3
	}

	public enum AnimeTypes
	{
		Movie,
		OVA,
		TV_Series,
		TV_Special,
		Web,
		Other
	}

	public enum ImportFolderType
	{
		HDD = 1, // files stored on a "permanent" hard drive
		DVD = 2 // files stored on a cd/dvd 
	}

	public enum ScheduledUpdateType
	{
		AniDBCalendar = 1,
		TvDBInfo = 2,
		AniDBUpdates = 3,
		AniDBTitles = 4,
		AniDBMyListSync = 5,
		TraktSync = 6,
		TraktUpdate = 7
	}

	public enum JMMImageType
	{
		AniDB_Cover = 1,
		AniDB_Character = 2,
		AniDB_Creator = 3,
		TvDB_Banner = 4,
		TvDB_Cover = 5,
		TvDB_Episode = 6,
		TvDB_FanArt = 7,
		MovieDB_FanArt = 8,
		MovieDB_Poster = 9,
		Trakt_Poster = 10,
		Trakt_Fanart = 11,
		Trakt_Episode = 12,
		Trakt_Friend = 13
	}

	public enum ImageSizeType
	{
		Poster = 1,
		Fanart = 2,
		WideBanner = 3
	}

	public enum ImageDownloadEventType
	{
		Started = 1,
		Complete = 2
	}

	public enum AniDBVoteType
	{
		Anime = 1,
		AnimeTemp = 2,
		Group = 3,
		Episode = 4
	}

	public enum TvDBImageNodeType
	{
		Series = 1,
		Season = 2
	}

	public enum CrossRefType
	{
		MovieDB = 1,
		MyAnimeList = 2,
		AnimePlanet = 3,
		BakaBT = 4,
		TraktTV = 5,
		AnimeNano = 6,
		CrunchRoll = 7,
		Konachan = 8
	}

	public enum ScheduledUpdateFrequency
	{
		Never = 1,
		HoursSix = 2,
		HoursTwelve = 3,
		Daily = 4
	}

	public enum GroupFilterConditionType
	{
		CompletedSeries = 1,
		MissingEpisodes = 2,
		HasUnwatchedEpisodes = 3,
		AllEpisodesWatched = 4,
		UserVoted = 5,
		Category = 6,
		AirDate = 7,
		Studio = 8,
		AssignedTvDBInfo = 9,
		ReleaseGroup = 11,
		AnimeType = 12,
		VideoQuality = 13,
		Favourite = 14,
		AnimeGroup = 15,
		AniDBRating = 16,
		UserRating = 17,
		SeriesCreatedDate = 18,
		EpisodeAddedDate = 19,
		EpisodeWatchedDate = 20,
		FinishedAiring = 21,
		MissingEpisodesCollecting = 22,
		AudioLanguage = 23,
		SubtitleLanguage = 24,
		AssignedTvDBOrMovieDBInfo = 25,
		AssignedMovieDBInfo = 26,
		UserVotedAny = 27
	}

	public enum GroupFilterOperator
	{
		Include = 1,
		Exclude = 2,
		GreaterThan = 3,
		LessThan = 4,
		Equals = 5,
		NotEquals = 6,
		In = 7,
		NotIn = 8,
		LastXDays = 9,
		InAllEpisodes = 10,
		NotInAllEpisodes = 11
	}

	public enum GroupFilterSorting
	{
		SeriesAddedDate = 1,
		EpisodeAddedDate = 2,
		EpisodeAirDate = 3,
		EpisodeWatchedDate = 4,
		GroupName = 5,
		Year = 6,
		SeriesCount = 7,
		UnwatchedEpisodeCount = 8,
		MissingEpisodeCount = 9,
		UserRating = 10,
		AniDBRating = 11,
		SortName = 12
	}

	public enum GroupFilterSortDirection
	{
		Asc = 1,
		Desc = 2
	}

	public enum GroupFilterBaseCondition
	{
		Include = 1,
		Exclude = 2
	}


	public enum enAnimeType
	{
		Movie = 0,
		OVA = 1,
		TVSeries = 2,
		TVSpecial = 3,
		Web = 4,
		Other = 5
	}

	public enum StatCountType
	{
		Watched = 1,
		Played = 2,
		Stopped = 3
	}

	public enum DataSourceType
	{
		AniDB = 1,
		TheTvDB = 2
	}
}