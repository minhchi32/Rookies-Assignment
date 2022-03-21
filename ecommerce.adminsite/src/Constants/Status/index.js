import * as StatusConstants from "./StatusConstants";

export const checkStatus = (id) => {
	switch (id) {
		case 0:
			return StatusConstants.LabelShow;
		case 1:
			return StatusConstants.LabelHide;
		case 2:
			return StatusConstants.LabelDeleted;

		default:
			return null;
	}
};
