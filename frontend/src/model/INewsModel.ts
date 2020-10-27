interface INewsModel {
    url: string;
    thumbNail: string;
    title: string;
    pubDate: Date;
    refSourceId: number;
    id: number;
    creatTime: Date;
    editTime?: Date;
    isDelete: boolean;
    refCreatorId: number;
    refEditorId?: number;
}

export { INewsModel }