\
\ @file sec_dcache.fs
\ @brief Data cache
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

$00000001 constant SEC_DCACHE_DCACHE_CR_EN                          \ enable
$00000002 constant SEC_DCACHE_DCACHE_CR_CACHEINV                    \ full cache invalidation Can be set by software, only when EN = 1. Cleared by hardware when the BUSYF flag is set (during full cache invalidation operation). Writing 0 has no effect.
$00000700 constant SEC_DCACHE_DCACHE_CR_CACHECMD                    \ cache command maintenance operation (cleans and/or invalidates an address range) Can be set and cleared by software, only when no maintenance command is ongoing (BUSYCMDF = 0). others: reserved
$00000800 constant SEC_DCACHE_DCACHE_CR_STARTCMD                    \ starts maintenance command (maintenance operation defined in CACHECMD). Can be set by software, only when EN = 1, BUSYCMDF = 0, BUSYF = 0 and CACHECMD = 0b001, 0b010 or 0b011. Cleared by hardware when the BUSYCMDF flag is set (during cache maintenance operation). Writing 0 has no effect.
$00010000 constant SEC_DCACHE_DCACHE_CR_RHITMEN                     \ read-hit monitor enable
$00020000 constant SEC_DCACHE_DCACHE_CR_RMISSMEN                    \ read-miss monitor enable
$00040000 constant SEC_DCACHE_DCACHE_CR_RHITMRST                    \ read-hit monitor reset
$00080000 constant SEC_DCACHE_DCACHE_CR_RMISSMRST                   \ read-miss monitor reset
$00100000 constant SEC_DCACHE_DCACHE_CR_WHITMEN                     \ write-hit monitor enable
$00200000 constant SEC_DCACHE_DCACHE_CR_WMISSMEN                    \ write-miss monitor enable
$00400000 constant SEC_DCACHE_DCACHE_CR_WHITMRST                    \ write-hit monitor reset
$00800000 constant SEC_DCACHE_DCACHE_CR_WMISSMRST                   \ write-miss monitor reset
$80000000 constant SEC_DCACHE_DCACHE_CR_HBURST                      \ output burst type for cache master port read accesses Write access is always done in INCR burst type.


\
\ @brief DCACHE status register
\ Address offset: 0x04
\ Reset value: 0x00000001
\

$00000001 constant SEC_DCACHE_DCACHE_SR_BUSYF                       \ full invalidate busy flag
$00000002 constant SEC_DCACHE_DCACHE_SR_BSYENDF                     \ full invalidate busy end flag Cleared by writing DCACHE_FCR.CBSYENDF = 1.
$00000004 constant SEC_DCACHE_DCACHE_SR_ERRF                        \ cache error flag Cleared by writing DCACHE_FCR.CERRF = 1.
$00000008 constant SEC_DCACHE_DCACHE_SR_BUSYCMDF                    \ command busy flag
$00000010 constant SEC_DCACHE_DCACHE_SR_CMDENDF                     \ command end flag Cleared by writing DCACHE_FCR.CCMDENDF = 1.


\
\ @brief DCACHE interrupt enable register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000002 constant SEC_DCACHE_DCACHE_IER_BSYENDIE                   \ interrupt enable on busy end Set by SW to enable an interrupt generation at the end of a cache full invalidate operation.
$00000004 constant SEC_DCACHE_DCACHE_IER_ERRIE                      \ interrupt enable on cache error Set by software to enable an interrupt generation in case of cache functional error (eviction or clean operation write-back error)
$00000010 constant SEC_DCACHE_DCACHE_IER_CMDENDIE                   \ interrupt enable on command end Set by software to enable an interrupt generation at the end of a cache command (clean and/or invalidate an address range)


\
\ @brief DCACHE flag clear register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000002 constant SEC_DCACHE_DCACHE_FCR_CBSYENDF                   \ clear full invalidate busy end flag Set by software.
$00000004 constant SEC_DCACHE_DCACHE_FCR_CERRF                      \ clear cache error flag Set by software.
$00000010 constant SEC_DCACHE_DCACHE_FCR_CCMDENDF                   \ clear command end flag Set by software.


\
\ @brief DCACHE read-hit monitor register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant SEC_DCACHE_DCACHE_RHMONR_RHITMON                 \ cache read-hit monitor counter


\
\ @brief DCACHE read-miss monitor register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant SEC_DCACHE_DCACHE_RMMONR_RMISSMON                \ cache read-miss monitor counter


\
\ @brief DCACHE write-hit monitor register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant SEC_DCACHE_DCACHE_WHMONR_WHITMON                 \ cache write-hit monitor counter


\
\ @brief DCACHE write-miss monitor register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant SEC_DCACHE_DCACHE_WMMONR_WMISSMON                \ cache write-miss monitor counter


\
\ @brief DCACHE command range start address register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$fffffff0 constant SEC_DCACHE_DCACHE_CMDRSADDRR_CMDSTARTADDR        \ start address of range to which the cache maintenance command specified in DCACHE_CR.CACHECMD field applies This register must be set before DCACHE_CR.CACHECMD is written. .


\
\ @brief DCACHE command range end address register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$fffffff0 constant SEC_DCACHE_DCACHE_CMDREADDRR_CMDENDADDR          \ end address of range to which the cache maintenance command specified in DCACHE_CR.CACHECMD field applies This register must be set before DCACHE_CR.CACHECMD is written.


\
\ @brief Data cache
\
$50031400 constant SEC_DCACHE_DCACHE_CR  \ offset: 0x00 : DCACHE control register
$50031404 constant SEC_DCACHE_DCACHE_SR  \ offset: 0x04 : DCACHE status register
$50031408 constant SEC_DCACHE_DCACHE_IER  \ offset: 0x08 : DCACHE interrupt enable register
$5003140c constant SEC_DCACHE_DCACHE_FCR  \ offset: 0x0C : DCACHE flag clear register
$50031410 constant SEC_DCACHE_DCACHE_RHMONR  \ offset: 0x10 : DCACHE read-hit monitor register
$50031414 constant SEC_DCACHE_DCACHE_RMMONR  \ offset: 0x14 : DCACHE read-miss monitor register
$50031420 constant SEC_DCACHE_DCACHE_WHMONR  \ offset: 0x20 : DCACHE write-hit monitor register
$50031424 constant SEC_DCACHE_DCACHE_WMMONR  \ offset: 0x24 : DCACHE write-miss monitor register
$50031428 constant SEC_DCACHE_DCACHE_CMDRSADDRR  \ offset: 0x28 : DCACHE command range start address register
$5003142c constant SEC_DCACHE_DCACHE_CMDREADDRR  \ offset: 0x2C : DCACHE command range end address register

