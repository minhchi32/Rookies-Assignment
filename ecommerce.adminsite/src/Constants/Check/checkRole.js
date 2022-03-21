const LabelAdmin = 'Admin';
const LabelCustomer = 'Customer';

const StatusAdmin = 1;
const StatusCustomer = 2;
export const checkRole = (id) => {
	switch (id) {
		case StatusAdmin:
			return LabelAdmin;
		case StatusCustomer:
			return LabelCustomer;

		default:
			return null;
	}
};
