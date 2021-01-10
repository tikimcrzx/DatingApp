export interface Pagination {
  currentPage: number;
  itemsPerPages: number;
  totalPages: number;
  totalItems: number;
}

export class PaginatedResult<T> {
  result: T;
  pagination: Pagination;
}
