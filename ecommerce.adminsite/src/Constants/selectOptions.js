import { 
    CheckIsShowOnHome,
    CheckIsNotShowOnHome,
    CheckIsShowOnHomeLabel,
    CheckIsNotShowOnHomeLabel,
    CheckActive,
    CheckInActive,
    CheckActiveLabel,
    CheckInActiveLabel
} from "./Category/CategoryConstants";

import { 
    CheckIsFeatured,
    CheckIsFeaturedLabel,
    CheckIsNotFeatured,
    CheckIsNotFeaturedLabel
} from "../Constants/Product/ProductConstants";

export const isFeaturedProductOptions = [
    { id: 1, label: CheckIsFeaturedLabel, value: CheckIsFeatured },
    { id: 0, label: CheckIsNotFeaturedLabel, value: CheckIsNotFeatured },
];

export const checkActive = [
    { id: 1, label: CheckActive, value: CheckActiveLabel },
    { id: 0, label: CheckInActive, value: CheckInActiveLabel },
];