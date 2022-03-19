import React from 'react';
import "./Table.css";

const Paging = ({ pageIndex = 1, pageCount = 1, handleChange }) => {
    const prePageStyle = pageIndex !== 1 ? 'pagination__link' : 'pagination__link link-disable';
    const nextPageStyle = pageIndex + 1 <= pageCount ? 'pagination__link' : 'pagination__link link-disable';

    const pageStyle = (page) => {
        if (page === pageIndex) return 'pagination__link link-active';
        return 'pagination__link';
    };

    const onPrev = (e) => {
        e.preventDefault();

        if (pageIndex !== 1) {
            handleChange(pageIndex - 1);
        }
    };

    const onNext = (e) => {
        e.preventDefault();

        if (pageIndex + 1 <= pageCount) {
            handleChange(pageIndex + 1);
        }
    };

    const onPageNumber = (e, page) => {
        e.preventDefault();
        handleChange(page);
    };

    return (
        <div className="w-100 d-flex align-items-center mt-3">
            <ul className="pagination">
                <li className="intro-x">
                    <a onClick={onPrev} className={prePageStyle}>
                        Previous
                    </a>
                </li>

                {
                    [...Array(pageCount).keys()].map(i => (
                        <li key={i} className="intro-x">
                            <a onClick={e => onPageNumber(e, i + 1)} className={pageStyle(i + 1)}
                            >
                                {i + 1}
                            </a>
                        </li>
                    ))
                }

                <li className="intro-x">
                    <a onClick={onNext} className={nextPageStyle}>Next</a>
                </li>

            </ul>
        </div>
    );
};

export default Paging;