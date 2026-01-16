\
\ @file dcache.fs
\ @brief DCACHE register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DCACHE control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant DCACHE_DCACHE_CR_EN                              \ enable
$00000002 constant DCACHE_DCACHE_CR_CACHEINV                        \ full cache invalidation
$00000700 constant DCACHE_DCACHE_CR_CACHECMD                        \ cache command maintenance operation (cleans and/or invalidates an address range)
$00000800 constant DCACHE_DCACHE_CR_STARTCMD                        \ starts maintenance command (maintenance operation defined in CACHECMD).
$00010000 constant DCACHE_DCACHE_CR_RHITMEN                         \ read-hit monitor enable
$00020000 constant DCACHE_DCACHE_CR_RMISSMEN                        \ read-miss monitor enable
$00040000 constant DCACHE_DCACHE_CR_RHITMRST                        \ read-hit monitor reset
$00080000 constant DCACHE_DCACHE_CR_RMISSMRST                       \ read-miss monitor reset
$00100000 constant DCACHE_DCACHE_CR_WHITMEN                         \ write-hit monitor enable
$00200000 constant DCACHE_DCACHE_CR_WMISSMEN                        \ write-miss monitor enable
$00400000 constant DCACHE_DCACHE_CR_WHITMRST                        \ write-hit monitor reset
$00800000 constant DCACHE_DCACHE_CR_WMISSMRST                       \ write-miss monitor reset
$80000000 constant DCACHE_DCACHE_CR_HBURST                          \ output burst type for cache master port read accesses


\
\ @brief DCACHE status register
\ Address offset: 0x04
\ Reset value: 0x00000001
\

$00000001 constant DCACHE_DCACHE_SR_BUSYF                           \ full invalidate busy flag
$00000002 constant DCACHE_DCACHE_SR_BSYENDF                         \ full invalidate busy end flag
$00000004 constant DCACHE_DCACHE_SR_ERRF                            \ cache error flag
$00000008 constant DCACHE_DCACHE_SR_BUSYCMDF                        \ command busy flag
$00000010 constant DCACHE_DCACHE_SR_CMDENDF                         \ command end flag


\
\ @brief DCACHE interrupt enable register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000002 constant DCACHE_DCACHE_IER_BSYENDIE                       \ interrupt enable on busy end
$00000004 constant DCACHE_DCACHE_IER_ERRIE                          \ interrupt enable on cache error
$00000010 constant DCACHE_DCACHE_IER_CMDENDIE                       \ interrupt enable on command end


\
\ @brief DCACHE flag clear register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000002 constant DCACHE_DCACHE_FCR_CBSYENDF                       \ clear full invalidate busy end flag
$00000004 constant DCACHE_DCACHE_FCR_CERRF                          \ clear cache error flag
$00000010 constant DCACHE_DCACHE_FCR_CCMDENDF                       \ clear command end flag


\
\ @brief DCACHE read-hit monitor register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant DCACHE_DCACHE_RHMONR_RHITMON                     \ cache read-hit monitor counter


\
\ @brief DCACHE read-miss monitor register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant DCACHE_DCACHE_RMMONR_RMISSMON                    \ cache read-miss monitor counter


\
\ @brief DCACHE write-hit monitor register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant DCACHE_DCACHE_WHMONR_WHITMON                     \ cache write-hit monitor counter


\
\ @brief DCACHE write-miss monitor register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant DCACHE_DCACHE_WMMONR_WMISSMON                    \ cache write-miss monitor counter


\
\ @brief DCACHE command range start address register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$fffffff0 constant DCACHE_DCACHE_CMDRSADDRR_CMDSTARTADDR            \ start address of range to which the cache maintenance command specified in DCACHE_CR.


\
\ @brief DCACHE command range end address register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$fffffff0 constant DCACHE_DCACHE_CMDREADDRR_CMDENDADDR              \ end address of range to which the cache maintenance command specified in DCACHE_CR.


\
\ @brief DCACHE register block
\
$40031400 constant DCACHE_DCACHE_CR  \ offset: 0x00 : DCACHE control register
$40031404 constant DCACHE_DCACHE_SR  \ offset: 0x04 : DCACHE status register
$40031408 constant DCACHE_DCACHE_IER  \ offset: 0x08 : DCACHE interrupt enable register
$4003140c constant DCACHE_DCACHE_FCR  \ offset: 0x0C : DCACHE flag clear register
$40031410 constant DCACHE_DCACHE_RHMONR  \ offset: 0x10 : DCACHE read-hit monitor register
$40031414 constant DCACHE_DCACHE_RMMONR  \ offset: 0x14 : DCACHE read-miss monitor register
$40031420 constant DCACHE_DCACHE_WHMONR  \ offset: 0x20 : DCACHE write-hit monitor register
$40031424 constant DCACHE_DCACHE_WMMONR  \ offset: 0x24 : DCACHE write-miss monitor register
$40031428 constant DCACHE_DCACHE_CMDRSADDRR  \ offset: 0x28 : DCACHE command range start address register
$4003142c constant DCACHE_DCACHE_CMDREADDRR  \ offset: 0x2C : DCACHE command range end address register

