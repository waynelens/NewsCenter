import { INewsModel } from '@/model/INewsModel';

class CoreArticelViewModel {
    Id: number;
    Url: string;
    Thumbnail: string;
    Title: string;
    pubDate: string;

    constructor(res: INewsModel) {
        this.Id = res.id;
        this.Url = res.url;
        this.Thumbnail = res.thumbNail;
        this.Title = res.title;
        this.pubDate = new Date(res.pubDate).toUTCString();
    }
}

export { CoreArticelViewModel };