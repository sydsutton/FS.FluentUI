//* Copied over from @fluentui/react-datepicker-compat/lib/utils/dateFormatting/dateFormatting.defaults.js
// Because I couldn't find a way to import directly from that file otherwise.

const formatDay = (date)=>date.getDate().toString();

const formatMonthDayYear = (date, strings)=>strings.months[date.getMonth()] + ' ' + date.getDate() + ', ' + date.getFullYear();

const formatMonthYear = (date, strings)=>strings.months[date.getMonth()] + ' ' + date.getFullYear();

const formatMonth = (date, strings)=>strings.months[date.getMonth()];

const formatYear = (date)=>date.getFullYear().toString();

export const DEFAULT_DATE_FORMATTING = {
    formatDay,
    formatMonth,
    formatYear,
    formatMonthDayYear,
    formatMonthYear
};
