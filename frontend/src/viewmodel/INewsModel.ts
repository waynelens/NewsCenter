// 從backend接收news
interface INewsModel {
    // dbo.news
    id: number;
    url: string;
    thumbNail: string;
    title: string;
    pubDate: Date;
    // dbo.source
    logo: string;
    //dbo.bookmark
    isBookmark: boolean;
    //dbo.upvote
    upvoteCount: number;
    //dbo.comment
    commentCount: number;
}

export { INewsModel };