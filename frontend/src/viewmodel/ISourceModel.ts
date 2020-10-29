// 從backend接收source
interface ISourceModel {
    id: number;
    logo: string;
    name: string;
    rssFeed: string;
}

export { ISourceModel }